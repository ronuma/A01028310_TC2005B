/*
Program enemies to move horizontally

Rodrigo Núñez Magallanes
2023-03-08
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float upperLimit;
    [SerializeField] float lowerLimit;
    [SerializeField] int initialDirection;
    [SerializeField] Score scoreObj;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        move.x = initialDirection;   
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreObj.hasWon) {
            move.x = 0;
        } else {
            if (transform.position.x > upperLimit && move.x > 0) {
            move.x = -1;
        } else if (transform.position.x < lowerLimit && move.x < 0) {
            move.x = 1;
        }
        }
        transform.Translate(move * speed * Time.deltaTime);   
    }
}
