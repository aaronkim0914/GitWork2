using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    Rigidbody body;
   
    // Update is called once per frame
    void Update()
    {
        body = GetComponent<Rigidbody>();
    }
}
