using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpGage : MonoBehaviour
{
    private FrogMovement _frogMov;
    [SerializeField] private Image _image;

    private void Awake()
    {
        _frogMov = FindAnyObjectByType<FrogMovement>();
    }

    private void Update()
    {
        _image.fillAmount = _frogMov._jumpPower / _frogMov._maxJumpPower;
    }
}
