using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    [SerializeField] private StageSO _stageSO;
    public static Stage3 instance;
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
        stageLock = 2;
        PlayerPrefs.SetInt("Stage3", stageLock);
    }
}
