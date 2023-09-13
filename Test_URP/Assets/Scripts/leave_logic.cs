using UnityEngine;

public class leave_logic : MonoBehaviour
{
    public bool characterTouching = false;
    private float detachTime = 1f; // Time in seconds before detachment
    private float detachTimer = 0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Leaf starts kinematic
    }

    private void Update()
    {
        if (characterTouching)
        {
            detachTimer += Time.deltaTime;

            // Check if it's time to detach the leaf
            if (detachTimer >= detachTime)
            {
                rb.isKinematic = false; // Allow physics to take over
                characterTouching = false; // Prevent further checks
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the character touched the leaf
        if (other.CompareTag("kenyalang"))
        {
            characterTouching = true;
            Debug.Log("It touched");
        }
    }
}
