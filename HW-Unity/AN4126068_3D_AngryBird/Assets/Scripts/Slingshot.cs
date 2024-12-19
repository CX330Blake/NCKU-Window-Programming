using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Slingshot : MonoBehaviour {
    private static readonly int Time = Animator.StringToHash("time");
    public Transform player;
    public Rigidbody pullObject;
    public Animator slingshotTree;
    public Rigidbody projectile;
    public float powerDistance = 15f;
    public float powerMax = 30f;
#if UNITY_2023_1_OR_NEWER
    public Unity.Cinemachine.CinemachineCamera cinemachine;
#else
    public Cinemachine.CinemachineVirtualCamera cinemachine;
#endif
    public int targetLayer = 3;
    public Transform targetFollow;
    public Transform playerFollow;
    public Transform projectileFollow;
    public float grabForce = 150f;

    private float _time;

    void Start() {
        slingshotTree.Play("Release");
        slingshotTree.speed = 2;
    }

    void Update() {
        AnimatorStateInfo info = slingshotTree.GetCurrentAnimatorStateInfo(0);
        float time = info.normalizedTime > 1 ? 1 : info.normalizedTime;
        float power = Mathf.Lerp(0f, 1f, (transform.position - player.position).magnitude / powerDistance);
        // Mouse down
        if (Input.GetMouseButton((int)MouseButton.LeftMouse)) {
            Vector3 pos = player.position - transform.position;
            transform.forward = new Vector3(pos.x, 0, pos.z);
            if (info.IsName("Release")) {
                cinemachine.Follow = playerFollow;
                cinemachine.LookAt = playerFollow;
                slingshotTree.Play("Drag");
            } else if (info.IsName("Drag")) {
                if (time >= power)
                    slingshotTree.Play("Stay", 0, time);
            } else if (info.IsName("Stay")) {
                slingshotTree.SetFloat(Time, power);
            }

            var dir = player.position + player.rotation * new Vector3(0, 1, 1) - pullObject.position;
            pullObject.AddForce(dir * grabForce, ForceMode.Force);
            projectile.transform.rotation = Quaternion.LookRotation(-dir);
            projectile.transform.position = pullObject.transform.position;
            projectile.isKinematic = true;
        } else {
            // Fire
            if (projectile.isKinematic) {
                projectile.isKinematic = false;

                Debug.Log(power);
                projectile.AddForce((projectile.transform.position - player.transform.position).normalized * power * powerMax,
                    ForceMode.Impulse);
                Projectile projectileScript =
                    projectile.gameObject.GetComponent<Projectile>() ?? projectile.gameObject.AddComponent<Projectile>();
                projectileScript.StopAllCoroutines();
                projectileScript.cinemachine = cinemachine;
                projectileScript.Target = targetFollow;
                projectileScript.Player = playerFollow;
                projectileScript.TargetLayer = targetLayer;
                cinemachine.Follow = projectileFollow;
                cinemachine.LookAt = projectileFollow;
                StartCoroutine(StartFiring(projectileScript));
            }

            if (info.IsName("Release"))
                return;
            float start = info.IsName("Stay") ? 1 - power : 1 - time;
            slingshotTree.Play("Release", 0, start);
        }
    }

    private IEnumerator StartFiring(Projectile projectileScript) {
        yield return new WaitForSeconds(0.5f);
        projectileScript.StartFire();
    }
}