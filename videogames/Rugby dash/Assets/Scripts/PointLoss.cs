/*
Remove points if tiger is touched by enemy

Rodrigo Nunez Magallanes
2023-03-12
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLoss : MonoBehaviour
{
    [SerializeField] Score scoreObj;
    [SerializeField] int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Player") {
            scoreObj.RemovePoints(points);
        }
    }
}
