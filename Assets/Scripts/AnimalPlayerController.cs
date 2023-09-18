using Photon.Pun;
using UnityEngine;

public class AnimalPlayerController : MonoBehaviourPun
{
    private Rigidbody rb;
    public float moveSpeed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (photonView.IsMine)
        {
            // 로컬 플레이어의 컨트롤을 활성화합니다.
            // 여기서는 Rigidbody를 사용하여 움직임을 구현합니다.
        }
        else
        {
            // 원격 플레이어의 컴포넌트를 비활성화합니다.
            // 이동 및 제어는 다른 클라이언트에서 수행됩니다.
            rb.isKinematic = true;
        }
    }

    private void Update()
    {
        if (rb != null && photonView.IsMine)
        {
            // 나머지 코드...


            if (!photonView.IsMine) return;

            // 로컬 플레이어의 움직임을 제어합니다.
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
            rb.MovePosition(transform.position + movement);
        }
    }
}

