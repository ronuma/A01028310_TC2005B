using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision col)
    {
        GameObject obj = col.gameObject;
        Destroy(obj);
    }
}
