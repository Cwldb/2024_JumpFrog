using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4 : MonoBehaviour
{
    [SerializeField] private StageSO _stageSO;
    public static Stage4 instance;
    public int stageLock = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.CompareTag("Player");
        stageLock = 3;
        PlayerPrefs.SetInt("Stage4", stageLock);
    }
}
