/*
Update the score

Rodrigo Nunez Magallanes
2023-03-01
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text tmpObj;
    [SerializeField] int maxScore;
    [SerializeField] CreateBalls creator;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void AddPoints(int amount)
    {
        score += amount;
        // Update the text displayed on the screen
        tmpObj.text = "Score: " + score;
        // Debug.Log("New Score: " + score);

        if (score == maxScore) {
            Finish();
        }

        void Finish()
        {
            creator.StopBalls();
            tmpObj.text += "\n\nYou Won!";
        }
    }
}
