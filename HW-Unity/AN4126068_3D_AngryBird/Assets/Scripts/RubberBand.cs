using UnityEngine;

public class RubberBand : MonoBehaviour {
    public GameObject rubberBandStart;
    public GameObject rubberBandEnd;
    public Material ropeMaterial;
    public int springLayer;
    // public float ropeRadius = 0.05f;

    private GameObject[] points;

    // private ComputeBuffer pointsBuffer;
    private Mesh mesh;
    private LineRenderer _lineRenderer;

    void Start() {
        Rigidbody lastRB = rubberBandStart.GetComponent<Rigidbody>();
        Transform lastTransform = rubberBandStart.transform;
        points = new GameObject[10];
        points[0] = rubberBandStart;
        Vector3 dir = new Vector3(0, 0, -1) / (points.Length - 1);
        for (int i = 1; i < points.Length; i++) {
            GameObject point;
            Rigidbody rb;
            SpringJoint sj;
            if (i + 1 == points.Length) {
                point = rubberBandEnd;
                rb = point.GetComponent<Rigidbody>();
                sj = point.AddComponent<SpringJoint>();
            } else {
                point = new GameObject("Point_" + i);
                point.transform.parent = gameObject.transform;
                point.transform.position = lastTransform.position + dir;
                point.layer = springLayer;
                rb = point.AddComponent<Rigidbody>();
                sj = point.AddComponent<SpringJoint>();
                SphereCollider sc = point.AddComponent<SphereCollider>();
                sc.radius = 0.05f;
            }

            rb.mass = 1f;
#if UNITY_6000_0_OR_NEWER
            rb.linearDamping = 3;
            rb.angularDamping = 3;
#else
            rb.drag = 3;
            rb.angularDrag = 3;
#endif
            rb.freezeRotation = true;
            sj.autoConfigureConnectedAnchor = false;
            sj.spring = 400f;
            sj.damper = 10f;
            sj.minDistance = 0f;
            sj.maxDistance = 0f;
            sj.connectedBody = lastRB;
            sj.enableCollision = true;

            points[i] = point;
            lastRB = rb;
            lastTransform = rb.transform;
        }

        mesh = new Mesh { vertices = new Vector3[points.Length] };
        int[] indices = new int[points.Length];
        for (int i = 0; i < indices.Length; i++) indices[i] = i;
        mesh.SetIndices(indices, MeshTopology.Points, 0);

        // pointsBuffer = new ComputeBuffer(points.Length, sizeof(float) * 3);
        // ropeMaterial.SetBuffer("_RopePoints", pointsBuffer);
        // ropeMaterial.SetFloat("_Radius", ropeRadius);
        // ropeMaterial.SetFloat("_PointCount", points.Length);

        // gameObject.AddComponent<MeshFilter>().mesh = mesh;
        // gameObject.AddComponent<MeshRenderer>().material = ropeMaterial;

        _lineRenderer = gameObject.AddComponent<LineRenderer>();
        _lineRenderer.positionCount = points.Length;
        _lineRenderer.material = ropeMaterial;
        _lineRenderer.endWidth = _lineRenderer.startWidth = 0.1f;
    }

    void Update() {
        if (points != null && points.Length > 0) {
            // Vector3[] pos = new Vector3[points.Length];
            for (int i = 0; i < points.Length; i++) {
                _lineRenderer.SetPosition(i, points[i].transform.position);
                // pos[i] = points[i].transform.position - gameObject.transform.position;
            }

            Vector3 force = default;
            var joints = points[^1].GetComponents<SpringJoint>();
            foreach (var joint in joints) {
                force += joint.currentForce;
            }

            Debug.DrawRay(points[^1].transform.position, force, Color.red);

            // pointsBuffer.SetData(pos);
        }
    }

    // private void OnDestroy() {
    //     pointsBuffer.Release();
    // }
}