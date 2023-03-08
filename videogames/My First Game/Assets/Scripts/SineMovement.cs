using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMovement : MonoBehaviour
{
    [SerializeField] float amplitude;
    [SerializeField] float speed;

    Vector3 initialPosition;
    Vector3 offset;
    float angle;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        offset = new Vector3(0, Mathf.Sin(angle) * amplitude, 0);
        transform.position = initialPosition + offset;
    }
}
