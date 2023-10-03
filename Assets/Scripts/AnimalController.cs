using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AnimalController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 60f;

    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    private Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Disable physics-driven rotation
    }

    private void Update()
    {
        // 움직임 관리
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        //좌우키 입력시 애니매이션 재생
        if (Input.GetAxis("Horizontal") != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        //전진,후진 키 입력시 애니매이션 재생
        if (Input.GetAxis("Vertical") != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        
        // 이동거리 계산
        Vector3 movementDirection = transform.forward * verticalInput;
        rb.velocity = movementDirection * moveSpeed;

        // 회전각도 계산
        Quaternion rotation = Quaternion.Euler(0, horizontalInput * rotationSpeed * Time.fixedDeltaTime, 0);
        rb.MoveRotation(rb.rotation * rotation);
    }
}