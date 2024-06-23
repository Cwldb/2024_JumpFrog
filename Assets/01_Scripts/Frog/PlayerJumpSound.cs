using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpSound : MonoBehaviour
{
    private FrogInput _frogInput;
    private FrogMovement _frogMovement;

    private void Awake()
    {
        _frogInput = GetComponent<FrogInput>();
        _frogMovement = GetComponent<FrogMovement>();
    }

    private void OnEnable()
    {
        _frogInput.OnJumpButtonReleased += CheckGround;
    }

    private void OnDisable()
    {
        _frogInput.OnJumpButtonReleased -= CheckGround;
    }

    private void Update()
    {
        
    }

    private void CheckGround()
    {
        if (_frogMovement.isGround)
        {
            JumpSound();
        }
    }

    private void JumpSound()
    {
        JumpAManager.instance._audioSource.Play();
    }
}
