/*
Update the score

Rodrigo Nunez Magallanes
2023-03-01
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddPoints(int amount)
    {
        score += amount;
        Debug.Log("New Score: " + score);
    }
}
