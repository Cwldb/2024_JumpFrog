using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingSO", menuName = "SO/Setting")]

public class SoundSO : ScriptableObject
{
    [Header("SoundSetting")]
    [field: Range(0f, 1f)]
    public float BGMSound = 1f;
}