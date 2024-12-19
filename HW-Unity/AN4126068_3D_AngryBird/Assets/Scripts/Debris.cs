using System.Collections;
using UnityEngine;

public class Debris : MonoBehaviour {
    void Start() {
        StartCoroutine(RemoveDebris());
    }

    private IEnumerator RemoveDebris() {
        yield return new WaitForSeconds(Random.Range(2f, 3f));

        yield return FadeInAndOut(false, Random.Range(1f, 2f));

        Destroy(gameObject);
    }

    private IEnumerator FadeInAndOut(bool fadeIn, float duration) {
        float counter = 0f;

        //Set Values depending on if fadeIn or fadeOut
        float a, b;
        if (fadeIn) {
            a = 0;
            b = 1;
        } else {
            a = 1;
            b = 0;
        }

        MeshRenderer tempRenderer = gameObject.GetComponent<MeshRenderer>();
        Material[] materials = tempRenderer.materials;
        Color[] currentColors = new Color[materials.Length];
        for (int i = 0; i < materials.Length; i++) {
            Material material = materials[i];
            currentColors[i] = material.color;

            material.SetFloat("_Mode", 2);
            material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            material.SetInt("_ZWrite", 0);
            material.DisableKeyword("_ALPHATEST_ON");
            material.EnableKeyword("_ALPHABLEND_ON");
            material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            material.renderQueue = 3000;
        }

        while (counter < duration) {
            counter += Time.deltaTime;
            float alpha = Mathf.Lerp(a, b, counter / duration);
            for (int i = 0; i < currentColors.Length; i++) {
                Material material = materials[i];
                Color currentColor = currentColors[i];
                material.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
            }

            float scale = alpha < 0.5f ? 0.5f : alpha;
            gameObject.transform.localScale = new Vector3(scale, scale, scale);

            yield return null;
        }
    }
}