using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heart_logic : MonoBehaviour
{
    public int hearts = 3;

    public Image heart1;
    public Image heart2;
    public Image heart3;
    // Start is called before the first frame update
    void Start()
    {
        heart1.enabled = true;
        heart2.enabled = true;
        heart3.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        hearts = RespawnPoint.healthpoints;
        if (hearts == 3){
        heart1.enabled = true;
        heart2.enabled = true;
        heart3.enabled = true;
        }
        else if (hearts == 2){
        heart1.enabled = true;
        heart2.enabled = true;
        heart3.enabled = false;
        }
        else if (hearts == 1){
        heart1.enabled = true;
        heart2.enabled = false;
        heart3.enabled = false;
        }
        else if (hearts == 0){
        heart1.enabled = false;
        heart2.enabled = false;
        heart3.enabled = false;
        }      
    }
}
