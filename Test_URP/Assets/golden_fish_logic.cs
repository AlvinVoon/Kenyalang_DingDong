using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class golden_fish_logic : MonoBehaviour
{
    public GameObject goldenFish;
    public TextMeshProUGUI golden_fish_score;
    private int score = 0; // Change score to an integer

    public float rotationSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        goldenFish.SetActive(true);
        UpdateScoreText(); // Update the score text when the game starts

    }

    // Update is called once per frame
    void Update()
    {
    transform.Rotate(Vector3.forward*rotationSpeed*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the character touched the trigger zone.
        if (other.CompareTag("kenyalang"))
        {
            goldenFish.SetActive(false);
            score++; // Increment the score by 1
            UpdateScoreText(); // Update the score text when the score changes
        }
    }

    // Helper function to update the score text
    void UpdateScoreText()
    {
        golden_fish_score.text = score.ToString(); // Convert the integer score to a string
    }
}



