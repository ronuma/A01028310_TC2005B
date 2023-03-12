/*
Update the score

Rodrigo Nunez Magallanes
2023-03-12
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text tmpObj;
    [SerializeField] int maxScore;
    [SerializeField] int lossScore;
    int score = 0;
    bool hasLost = false;
    public bool hasWon = false;

    void Start() {
        tmpObj.text = "Score: " + score;
    }

    public void AddPoints(int amount) {
        if (!hasLost) {
            score += amount;
            tmpObj.text = "Score: " + score;
        }
        if (score >= maxScore) {
            hasWon = true;
            tmpObj.text = "You beat them with " + score + " points!";
        }
    }

    public void RemovePoints(int amount) {
        if (!hasWon) {
            score -= amount;
            tmpObj.text = "Score: " + score;
        }
        if (score <= lossScore) {
            hasLost = true;
            tmpObj.text = "You lost the game!";
        }
    }

    
}
