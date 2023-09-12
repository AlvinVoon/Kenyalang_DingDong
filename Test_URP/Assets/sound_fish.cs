using UnityEngine;

public class sound_fish : MonoBehaviour
{
    public AudioClip collisionSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = collisionSound;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("kenyalang")) // Change "platform" to the tag of the GameObject you want to collide with.
        {
        Debug.Log("Touched it");
            audioSource.Play();
        }
    }
}