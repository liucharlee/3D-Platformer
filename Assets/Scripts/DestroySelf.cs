using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    void Update ()
    {
        if ( Input.GetKey(KeyCode.Space)) {

             Destroy(gameObject);
        }
    }
}
