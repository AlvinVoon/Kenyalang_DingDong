using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    void Update()
    {
        // Check if the player is grounded.

        // Player movement in the horizontal plane.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 moveDirection = new Vector3((verticalInput), 0f, (horizontalInput*-1)).normalized;
        Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;
        
        // Apply movement to the rigidbody.
        rb.MovePosition(transform.position + movement);

        // Player jump.
        if ( Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}