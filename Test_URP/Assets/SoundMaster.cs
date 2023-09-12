using UnityEngine;

public class SoundMaster : MonoBehaviour
{
    public AudioClip soundClip; // Reference to your sound clip
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundClip;
    }

    private void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play the sound
            audioSource.Play();
        }
    }
}
