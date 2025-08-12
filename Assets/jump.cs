using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody component
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Detect Spacebar press
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Apply upward force
        }
    }
}

