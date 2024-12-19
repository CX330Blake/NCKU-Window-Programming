Shader "Unlit/Rope Shader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Radius ("Radius", Float) = 0.1
        _PointCount ("Point Count", Float) = 10
        _SegmentCount ("Segment Count", Integer) = 16 // Number of vertices in the ring (circle)
    }
    SubShader
    {
        Tags
        {
            "RenderType"="Opaque"
        }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma geometry geom
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            // Properties
            sampler2D _MainTex;
            float4 _MainTex_ST;
            float _Radius;
            float _PointCount;
            int _SegmentCount;
            StructuredBuffer<float3> _RopePoints;

            struct appdata {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                uint vertexId : SV_VertexID;
            };

            struct v2g {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                uint vertexId : TEXCOORD1; // Store segment index
            };

            struct g2f {
                float2 uv : TEXCOORD0;
                // float3 worldPos : TEXCOORD1;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
                float3 normal : NORMAL;
            };

            float3 get_bisector(float3 p0, float3 p1, float3 p2) {
                float3 direction = p2 - p1;
                float3 last_direction = p1 - p0;
                if (length(last_direction) == 0)
                    return normalize(direction);
                if (length(direction) == 0)
                    return normalize(last_direction);
                return normalize(normalize(direction) + normalize(last_direction));
            }

            void get_ring(float3 bisector, out float3 binormal, out float3 normal) {
                // Compute a perpendicular vector (normal) to the direction
                float3 up = float3(1.0, 0.0, 0.0); // Default up vector
                if (abs(dot(bisector, up)) > 0.99)
                    up = float3(0.0, 1.0, 0.0); // If direction is aligned with up, pick another perpendicular vector

                // Compute the orthogonal basis (tangent, binormal, normal)
                binormal = normalize(cross(bisector, up)); // Tangent to the rope
                normal = cross(binormal, bisector); // Normal to the plane of the circle
            }

            [maxvertexcount(102)]
            void geom(point v2g input[1], inout TriangleStream<g2f> outStream) {
                if (input[0].vertexId + 1 == _PointCount)
                    return;

                uint index = input[0].vertexId;
                float3 current_point = _RopePoints[index];
                float3 next_point = _RopePoints[index + 1];

                // Compute the direction (tangent) from currentPoint to nextPoint
                float3 bisector = get_bisector(
                    index > 0 ? _RopePoints[index - 1] : current_point,
                    current_point,
                    _RopePoints[index + 1]);

                float3 bisector2 = get_bisector(
                    current_point,
                    next_point,
                    input[0].vertexId + 2 < _PointCount ? _RopePoints[index + 2] : next_point);

                float3 binormal1;
                float3 normal1;
                get_ring(bisector, binormal1, normal1);

                float3 binormal2;
                float3 normal2;
                get_ring(bisector2, binormal2, normal2);

                // Create the circle vertices around the currentPoint
                float angle_step = UNITY_TWO_PI / _SegmentCount; // Angle step for circle

                for (int i = 0; i < _SegmentCount; ++i) {
                    float angle = i * angle_step;
                    float angle_next = angle + angle_step;
                    // Calculate the position on the circle
                    float3 circle_point_x1 = current_point + _Radius * (cos(angle) * binormal1 + sin(angle) * normal1);
                    float3 circle_point_x2 = current_point + _Radius * (cos(angle_next) * binormal1 + sin(angle_next) *
                        normal1);

                    float3 circle_point_y1 = next_point + _Radius * (cos(angle) * binormal2 + sin(angle) * normal2);
                    float3 circle_point_y2 = next_point + _Radius * (cos(angle_next) * binormal2 + sin(angle_next) *
                        normal2);

                    
                    // Compute normals for each vertex in the strip
                    float3 normal_x1 = normalize(circle_point_x1 - current_point);
                    float3 normal_x2 = normalize(circle_point_x2 - current_point);
                    float3 normal_y1 = normalize(circle_point_y1 - next_point);
                    float3 normal_y2 = normalize(circle_point_y2 - next_point);

                    g2f o1, o2, o3, o4;

                    o1.uv = float2(0, 0); // UVs can be customized
                    o1.vertex = UnityObjectToClipPos(float4(circle_point_x1, 1.0));
                    o1.normal = normal_x1;

                    o2.uv = float2(1, 0); // UV for the second point
                    o2.vertex = UnityObjectToClipPos(float4(circle_point_x2, 1.0));
                    o2.normal = normal_x2;

                    o3.uv = float2(0, 1); // UV for the third point
                    o3.vertex = UnityObjectToClipPos(float4(circle_point_y1, 1.0));
                    o3.normal = normal_y1;

                    o4.uv = float2(1, 1); // UV for the third point
                    o4.vertex = UnityObjectToClipPos(float4(circle_point_y2, 1.0));
                    o4.normal = normal_y2;

                    outStream.Append(o1);
                    outStream.Append(o3);
                    outStream.Append(o2);
                    outStream.RestartStrip();

                    outStream.Append(o2);
                    outStream.Append(o3);
                    outStream.Append(o4);
                    outStream.RestartStrip();
                }
            }

            v2g vert(appdata v) {
                v2g o;
                o.vertex = v.vertex;
                o.vertexId = v.vertexId;
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o, o.vertex);
                return o;
            }

            fixed4 frag(g2f i) : SV_Target {
                // Sample the texture using the UV coordinates passed from the geometry shader
                fixed4 col = tex2D(_MainTex, i.uv);
                
                // Use the normal passed from the geometry shader
                float3 normal = normalize(i.normal); // Normalize the normal in case it's not already normalized

                // Light direction (you can use a fixed light direction or pass it as a uniform)
                float3 lightDir = normalize(float3(1.0, 1.0, 1.0)); // Example: light coming from top-right

                // Simple diffuse lighting (Lambertian shading)
                float diff = max(dot(normal, lightDir), 0.0); // Dot product gives the cosine of the angle

                // Modulate the texture color with the diffuse intensity
                col *= diff;

                // Apply fog (existing Unity fog system)
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}