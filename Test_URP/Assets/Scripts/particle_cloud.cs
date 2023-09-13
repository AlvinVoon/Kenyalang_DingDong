using UnityEngine;

public class particle_cloud : MonoBehaviour
{
    public ParticleSystem mparticle_cloud; // Reference to your Particle System
    public KeyCode triggerKey = KeyCode.Space; // Change this to the key you want to use.

    private void Update()
    {
        // Check if the specified key is pressed
        if (Input.GetKeyDown(triggerKey))
        {
            // Play the Particle System
            if (mparticle_cloud != null)
            {
                mparticle_cloud.Play();
            }
        }
    }
}