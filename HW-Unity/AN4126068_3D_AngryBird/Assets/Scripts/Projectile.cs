using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour {
    [HideInInspector]
#if UNITY_2023_1_OR_NEWER
    public Unity.Cinemachine.CinemachineCamera cinemachine;
#else
    public Cinemachine.CinemachineVirtualCamera cinemachine;
#endif
    [HideInInspector] public Transform Target;
    [HideInInspector] public Transform Player;
    [HideInInspector] public int TargetLayer;
    private bool _firing;
    private Rigidbody _rb;
    private int _checkStop;
    private bool _disableCollisionEvent;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
        Break.OnBreak += () => _checkStop = 0;
    }

    private void OnCollisionEnter(Collision other) {
        if (!_firing || _disableCollisionEvent)
            return;
        StopAllCoroutines();
        if (other.gameObject.layer == TargetLayer) {
            cinemachine.Follow = Target;
            cinemachine.LookAt = Target;
            _disableCollisionEvent = true;
            StartCoroutine(CheckCameraReturn());
        } else
            StartCoroutine(CameraReturn());
    }

    private IEnumerator CameraReturn() {
        yield return new WaitForSeconds(5);
        cinemachine.Follow = Player;
        cinemachine.LookAt = Player;
    }

    private IEnumerator CheckCameraReturn() {
        yield return new WaitForSeconds(2);
        while (true) {
#if UNITY_6000_0_OR_NEWER
            float force = _rb.linearVelocity.magnitude;
#else
            float force = _rb.velocity.magnitude;
#endif
            if (force < 3) {
                _checkStop++;
            } else
                _checkStop = 0;

            if (_checkStop > 10)
                break;

            yield return new WaitForSeconds(0.4f);
        }

        yield return new WaitForSeconds(3f);

        cinemachine.Follow = Player;
        cinemachine.LookAt = Player;
    }

    public void StartFire() {
        _firing = true;
        _disableCollisionEvent = false;
        StopAllCoroutines();
    }
}