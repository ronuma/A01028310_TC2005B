/*
Detect when the tiger scores a try and send him to starting position

Rodrigo Nunez Magallanes
2023-03-12
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try : MonoBehaviour
{
    [SerializeField] Score scoreObj;
    [SerializeField] int points;

    void Start() {}

    void OnTriggerEnter2D(Collider2D col) {
        scoreObj.AddPoints(points);
        col.transform.position = new Vector3(Random.Range(-8f, 8f), -6, 0);
    }
}
