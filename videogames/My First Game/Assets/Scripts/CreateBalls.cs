/*
Create balls in a random position along the x axis

Rodrigo Nunez Magallanes
2023-03-01
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalls : MonoBehaviour
{
    // class variable to be changed from the Unity interface
    // serializeField es que se haga cambiable desde unity. Gameobject es una clase de Unity
    [SerializeField] GameObject ball;
    [SerializeField] float delay;
    // Start is called before the first frame update
    void Start()
    {
        // Call the DropBall() function after 0.5 seconds 
        // and then keep calling it every 0.8 seconds
        InvokeRepeating("DropBall", 0.5f, delay);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void DropBall()
    {
        // generate a new random position
        Vector3 pos = new Vector3(Random.Range(-15.0f, 15.0f), 6, 0);
        // create a copy of the prefab
        GameObject obj = Instantiate(ball, pos, Quaternion.identity);
        // // Doom the object to die in 5 seconds
        // Destroy(obj, 5);
    }

    public void StopBalls() 
    {
        CancelInvoke("DropBall");
    }

}
