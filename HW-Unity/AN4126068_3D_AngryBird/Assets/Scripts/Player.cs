using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 70f;
    public Transform followTarget; // Assign the FollowTarget GameObject in the Inspector

    private Rigidbody rb;
    private Animator animator; // 新增 Animator

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>(); // 初始化 Animator

        if (followTarget == null)
        {
            Debug.LogError("FollowTarget is not assigned. Please assign it in the Inspector.");
        }

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // 處理滑鼠控制旋轉
        HandleMouseRotation();

        // 同步角色的水平旋轉
        SyncPlayerRotationWithFollowTarget();

        // 處理角色移動
        HandleMovement();
    }

    // 滑鼠控制旋轉
    private void HandleMouseRotation()
    {
        // 水平旋轉（左右）
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        followTarget.rotation *= Quaternion.AngleAxis(mouseX, Vector3.up);

        // 垂直旋轉（上下）
        float mouseY = -Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        followTarget.rotation *= Quaternion.AngleAxis(mouseY, Vector3.right);

        // 限制上下視角範圍
        var angles = followTarget.localEulerAngles;
        angles.z = 0; // 防止滾動
        angles.x = ClampAngle(angles.x, -30f, 50f); // 限制上下視角
        followTarget.localEulerAngles = angles;
    }

    // 同步角色的水平旋轉
    private void SyncPlayerRotationWithFollowTarget()
    {
        // 只同步水平旋轉
        Vector3 targetEulerAngles = followTarget.eulerAngles;
        transform.rotation = Quaternion.Euler(0, targetEulerAngles.y, 0);
    }

    // 角色移動
    private void HandleMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // 計算移動方向
        Vector3 movement = (followTarget.forward * moveVertical + followTarget.right * moveHorizontal).normalized;
        Vector3 newPosition = rb.position + movement * moveSpeed * Time.deltaTime;

        // 移動角色
        rb.MovePosition(newPosition);

        // 判斷是否在移動，設置動畫
        bool isMoving = movement.magnitude > 0; // 檢查是否有輸入
        animator.SetBool("isMoving", isMoving); // 設置動畫參數
    }

    // 限制角度範圍
    private float ClampAngle(float angle, float min, float max)
    {
        if (angle > 180) angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}
