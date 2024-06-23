using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BGM_set : MonoBehaviour
{
    [SerializeField] private SoundSO setting;

    public void BGM_Slider(float Value)
    {
        setting.BGMSound = Value;
    }
}
