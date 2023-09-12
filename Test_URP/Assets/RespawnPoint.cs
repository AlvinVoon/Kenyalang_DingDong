using UnityEngine;
using System.Collections;

public class RespawnOnTouch : MonoBehaviour
{
    public Transform respawnPoint; // The point where the character will respawn.

    public int healthpoints = 3;
   
    private void OnTriggerEnter(Collider other)
    {
        // Check if the character touched the trigger zone.
        if (other.CompareTag("RespawnTrigger"))
        {
                StartCoroutine(Respawn());
        }
    }

        private IEnumerator Respawn()
        {
           yield return new WaitForSeconds(2.0f);
              transform.position = respawnPoint.position;
        }
}
