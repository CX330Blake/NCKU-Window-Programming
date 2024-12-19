using System;
using System.Collections;
using System.Collections.Generic;
using Hanzzz.MeshDemolisher;
using UnityEngine;
using Random = UnityEngine.Random;

public class Break : MonoBehaviour {
    public Transform debrisParent;
    private static readonly MeshDemolisher Demolisher = new MeshDemolisher();
    private Material _material;
    private Renderer _renderer;
    private Rigidbody _rb;

    public static event Action OnBreak;

    void Start() {
        _material = GetComponent<MeshRenderer>().sharedMaterial;
        _renderer = GetComponent<Renderer>();
        _rb = GetComponent<Rigidbody>();
    }

    void Update() {
    }

    private void OnCollisionEnter(Collision other) {
        // Debug.Log(other.impulse.magnitude);
        if (other.impulse.magnitude < 6 || _rb.isKinematic)
            return;

        _rb.isKinematic = true;
        OnBreak?.Invoke();
        StartCoroutine(HandleDemolition());
    }


    private IEnumerator HandleDemolition() {
        Bounds bounds = _renderer.bounds;

        for (int trys = 0; trys < 5; trys++) {
            var points = new List<Vector3>();
            for (int i = 0; i < 10; i++) {
                Vector3 point = new Vector3(
                    Random.Range(bounds.min.x, bounds.max.x),
                    Random.Range(bounds.min.y, bounds.max.y),
                    Random.Range(bounds.min.z, bounds.max.z));
                // while (true) {
                //     point = new Vector3(
                //         Random.Range(bounds.min.x, bounds.max.x),
                //         Random.Range(bounds.min.y, bounds.max.y),
                //         Random.Range(bounds.min.z, bounds.max.z));
                //     if (points.FindAll(p => Vector3.Distance(p, point) < 0.2f).Count == 0)
                //         break;
                // }

                points.Add(point);
            }

            var demolitionTask = Demolisher.DemolishAsync(gameObject, debrisParent, points, _material);
            while (!demolitionTask.IsCompleted)
                yield return null; // Wait for the next frame

            if (demolitionTask.IsCompletedSuccessfully) {
                Destroy(gameObject);
                List<GameObject> objs = demolitionTask.Result;
                foreach (var i in objs) {
                    i.AddComponent<Rigidbody>();
                    i.AddComponent<MeshCollider>().convex = true;
                    i.AddComponent<Debris>();
                }

                break;
            }

            // if (demolitionTask.Exception != null)
            //     Debug.LogException(demolitionTask.Exception);
            // throw demolitionTask.Exception;
        }
    }
}