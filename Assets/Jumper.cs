using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jumper : MonoBehaviour
{
    public enum JumpState { Ground, Jump, fall }
    private JumpState state = JumpState.Ground;


    private Rigidbody rb;

    [SerializeField, Range(0f, 20f)]
    private float jumpPower = 10f;

    private bool isJump = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && isJump)
        {
            rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
            Debug.Log("�����Ѵ�.");
        }
    }

    private IEnumerator Ground()
    {
        Debug.Log("��");
        yield return null;
    }

    private IEnumerator Jump()
    {
        Debug.Log("����");
        yield return null;
    }

    private IEnumerator Fall()
    {
        Debug.Log("�߶�");
        yield return null;
    }
}
