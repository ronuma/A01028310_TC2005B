/*
Move the Tiger upwards or sideways using the arrow keys.

Rodrigo Núñez Magallanes
2023-03-08
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerMovement : MonoBehaviour
{

    [SerializeField] float speed;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            move.x = Input.GetAxis("Horizontal");
            move.y = Input.GetAxis("Vertical");
            transform.Translate(move * speed * Time.deltaTime);
    }
}
