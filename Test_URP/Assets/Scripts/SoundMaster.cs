using UnityEngine;

public class SoundMaster : MonoBehaviour
{
    public AudioClip soundClip1; // Reference to your sound clip

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundClip1;
    }

    private void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
        }
    }
}
