using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarController : MonoBehaviour
{
    public Transform centerOfMass;  // Adjust the center of mass for stability
    public float maxSteerAngle = 30f;
    public float motorForce = 1500f;
    public float brakeForce = 2000f;

    private Rigidbody rb;
    private float steerInput;
    private float accelerationInput;
    private bool isBraking;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centerOfMass.localPosition;
    }

    private void Update()
    {
        // Get player input for steering and acceleration/braking
        steerInput = Input.GetAxis("Horizontal");
        accelerationInput = Input.GetAxis("Vertical");
        isBraking = Input.GetKey(KeyCode.Space);
    }

    private void FixedUpdate()
    {
        ApplySteering();
        ApplyAccelerationAndBraking();
    }

    private void ApplySteering()
    {
        float steerAngle = maxSteerAngle * steerInput;
        Quaternion steerRotation = Quaternion.Euler(0f, steerAngle, 0f);
        rb.MoveRotation(rb.rotation * steerRotation);
    }

    private void ApplyAccelerationAndBraking()
    {
        float motorTorque = accelerationInput * motorForce;
        float brakeTorque = isBraking ? brakeForce : 0f;

        // Apply torque to rear wheels for acceleration/braking
        rb.AddRelativeTorque(Vector3.up * steerInput * motorTorque);

        // Apply braking force to all wheels
        rb.AddForce(-rb.velocity.normalized * brakeTorque);
    }
}