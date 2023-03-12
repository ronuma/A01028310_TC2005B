using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        col.transform.position = new Vector3(Random.Range(-8f, 8f), -5, 0);
    } 
}
