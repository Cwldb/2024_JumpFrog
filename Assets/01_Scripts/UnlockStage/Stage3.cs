using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    [SerializeField] private StageSO _stageSO;
    public static Stage3 instance;
    public bool stageLock = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.CompareTag("Player");
        stageLock = true;
    }
}