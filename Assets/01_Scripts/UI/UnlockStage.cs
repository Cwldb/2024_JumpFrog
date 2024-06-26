using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockStage : MonoBehaviour
{
    [SerializeField] private GameObject _stage2;
    [SerializeField] private GameObject _stage3;
    [SerializeField] private GameObject _stage4;

    private int stage2;
    private int stage3;
    private int stage4;

    private void Awake()
    {
        stage2 = PlayerPrefs.GetInt("Stage2", 0);
        stage3 = PlayerPrefs.GetInt("Stage3", 0);
        stage4 = PlayerPrefs.GetInt("Stage4", 0);
    }

    private void Start()
    {
        if (stage2 == 1)
        {
            _stage2.SetActive(false);
        }
        if (stage3 == 2)
        {
            _stage3.SetActive(false);
        }
        if (stage4 == 3)
        {
            _stage4.SetActive(false);
        }
    }
}
