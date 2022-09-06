using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jumper : MonoBehaviour
{
    public enum JumpState { Ground, Jump, fall }
    private JumpState state = JumpState.Ground;

    /// <summary>
    /// //
    /// </summary>
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
        if (Input.GetButtonDown("Jump"))
        {
            ChangeState(JumpState.Jump);
           
            Debug.Log("점프한다.");
        }
    }

    private void Start()
    {
        ChangeState(state);
    }


    private void ChangeState(JumpState nextState)
    {
        StopCoroutine(state.ToString());
        state = nextState;
        StartCoroutine(state.ToString());
    }

    private IEnumerator Ground()
    {
        Debug.Log("땅");
        yield return null;
    }

    private IEnumerator Jump()
    {
        Debug.Log("점프");
        yield return null;
    }

    private IEnumerator Fall()
    {
        Debug.Log("추락");
        yield return null;
    }
}
