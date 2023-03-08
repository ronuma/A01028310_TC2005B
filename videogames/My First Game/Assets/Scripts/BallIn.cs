/*
Detect when the ball goes inside the net

Rodrigo Nunez Magallanes
2023-03-01
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallIn : MonoBehaviour
{
    [SerializeField] Score scoreObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Detect two elements in contact
    void OnTriggerEnter2D(Collider col)
    {
        if (col.tag == "Ball") {
            scoreObj.AddPoints(1);
        }
    }
}
