using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

public class FrogInput : MonoBehaviour
{
    public event Action OnJumpButtonPressed;
    public event Action OnJumpButtonReleased;

    public Vector2 moveDir { get; private set; }

    private void Update()
    {
        MoveInput();
        JumpInput();
    }

    public void MoveInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        moveDir = new Vector2(x, 0);
    }

    public void JumpInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            OnJumpButtonPressed.Invoke();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            OnJumpButtonReleased.Invoke();
        }
    }


    
}
