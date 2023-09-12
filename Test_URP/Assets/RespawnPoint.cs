using UnityEngine;
using System.Collections;

public class RespawnPoint : MonoBehaviour
{
    public Transform respawnPoint; // The point where the character will respawn.
    public Vector3 oriRotation = new Vector3(-67.81f, 0, 0); // Corrected the spelling of Vector and the default rotation.

    public static int healthpoints = 3;

    public static int overlaytrigger = 0;
   
    private void OnTriggerEnter(Collider other)
    {
        // Check if the character touched the trigger zone.
        if (other.CompareTag("RespawnTrigger"))
        {
            overlaytrigger = 1;
            StartCoroutine(Respawn());
            if (healthpoints != 0)
            {
            healthpoints = healthpoints-1;
            }
        }
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2.0f);

        overlaytrigger = 0;
        // Set the position to the respawn point.
        transform.position = respawnPoint.position;

        // Reset the rotation to the original rotation.
        transform.rotation = Quaternion.Euler(oriRotation);
    }
}
