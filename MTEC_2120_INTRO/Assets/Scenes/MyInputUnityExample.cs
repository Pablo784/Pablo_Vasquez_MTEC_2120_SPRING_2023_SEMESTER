using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MyInputUnityExample : MonoBehaviour
{
    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("On Jump Called");
        Rigidbody rigid = GetComponent<Rigidbody>();
        rigid.AddForce(0, 100, 0);
    }
}