using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StageSO", menuName = "SO/Stage")]

public class StageSO : ScriptableObject
{
    public int stage = 0;
    private void Awake()
    {
        stage = 0;
    }

}
