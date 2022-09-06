using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jumper : MonoBehaviour
{
    
   private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
            Debug.Log("점프한다.");
        }
    }
}
