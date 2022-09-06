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
    private float jumpPower = 20f;

    private bool isJump = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    //디벨롭 브렌치(중간다리)
    //피처를 따온다.
    //개발용 메인 브렌치

    void Update()
    {
        //// ///
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
