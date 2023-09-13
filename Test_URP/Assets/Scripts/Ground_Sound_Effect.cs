using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Sound_Effect : MonoBehaviour
{
    public AudioClip ground; // Reference to your sound clip

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
                audioSource = GetComponent<AudioSource>();
        audioSource.clip = ground;
                audioSource.volume = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter(Collider other)
    {
        // Check if the character touched the trigger zone.
        if (other.CompareTag("kenyalang"))
        {
            audioSource.Play();
        }
    }
}
