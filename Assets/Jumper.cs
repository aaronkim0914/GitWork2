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


    //�𺧷� �귻ġ(�߰��ٸ�)
    //��ó�� ���´�.
    //���߿� ���� �귻ġ
    //������ �귻ġ (���� ������)

    //������ �귣ġ, �𺧷� �귻ġ �� �ΰ� �ݵ�� ����� �ֱ�
    void Update()
    {
        //// ///
        if (Input.GetButtonDown("Jump"))
        {
            ChangeState(JumpState.Jump);
           
            Debug.Log("�����Ѵ�.");
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
