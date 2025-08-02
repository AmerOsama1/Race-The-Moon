using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f; // Tilt speed
    [SerializeField] private float speed = 5f;           // Move speed
    [SerializeField] private float maxTilt = 45f;        // Max Z tilt

    private Rigidbody rb;
    private float targetZ = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // disable physics rotation
        rb.interpolation = RigidbodyInterpolation.Interpolate;
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        // Calculate target Z rotation based on input
        targetZ = Mathf.Clamp(-input * maxTilt, -maxTilt, maxTilt); // Negative for natural tilt

        // Smoothly tilt toward target Z
        Quaternion targetRot = Quaternion.Euler(0f, 0f, targetZ);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        float input = Input.GetAxis("Horizontal");

        // Move left/right using Rigidbody
        Vector3 velocity = new Vector3(input * speed, rb.linearVelocity.y, 0f);
        rb.linearVelocity = velocity;
    }
}
