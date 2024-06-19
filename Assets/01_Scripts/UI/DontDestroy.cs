using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public bool destroyG = false;

    public static DontDestroy instance;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        destroyG = true;

    }

    private void Update()
    {
        
    }
}
