using UnityEngine;

public class BGMController : MonoBehaviour
{
    public GameObject objectToDeactivate; // 1번 개체
    public GameObject objectToActivate;   // 2번 개체

    private bool wasActive = true; // 1번 개체의 이전 활성화 상태

    private void Update()
    {
        // 1번 개체의 현재 활성화 상태를 확인
        bool isActive = objectToDeactivate.activeSelf;

        // 1번 개체가 비활성화되었을 때 2번 개체 활성화
        if (wasActive && !isActive)
        {
            objectToActivate.SetActive(true);
        }

        wasActive = isActive; // 이전 활성화 상태 업데이트
    }
}