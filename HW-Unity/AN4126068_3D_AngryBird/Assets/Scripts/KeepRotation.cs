using UnityEngine;

public class KeepRotation : MonoBehaviour {
    void Update() {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
    }
}