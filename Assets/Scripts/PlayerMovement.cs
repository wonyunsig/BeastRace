using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;
    public Animator animator; // Animator 컴포넌트를 가리키는 변수

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>(); // Animator 컴포넌트를 가져옵니다.
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);

        if (movement != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(movement);
            rb.rotation = Quaternion.RotateTowards(rb.rotation, newRotation, rotationSpeed * Time.deltaTime);

            // 애니메이션 파라미터 설정
            animator.SetBool("isRunning", true); // 플레이어가 움직일 때 달리기 애니메이션을 재생합니다.
        }
        else
        {
            // 플레이어가 멈출 때 달리기 애니메이션을 정지합니다.
            animator.SetBool("isRunning", false);
        }
    }
}