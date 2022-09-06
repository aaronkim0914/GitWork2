using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    
   
   
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("점프한다.");
        }
    }
}
