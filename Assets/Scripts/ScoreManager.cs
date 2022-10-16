using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
     public int score;
     public Text dscore;
     private void Update()
     {
        dscore.text = score.ToString();
     }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Obstacle"))
        {
            score++;

        }
    }
}
