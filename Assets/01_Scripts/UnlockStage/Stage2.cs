using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Stage2 : MonoBehaviour
{
    [SerializeField] private StageSO _stageSO;
    public static Stage2 instance;
    public int stageLock = 0;

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
        stageLock = 1;
        PlayerPrefs.SetInt("Stage2",stageLock);

    }
}
