using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockStage : MonoBehaviour
{
    [SerializeField] private GameObject _stage2;
    [SerializeField] private GameObject _stage3;
    [SerializeField] private GameObject _stage4;

    private void Start()
    {
        if (Stage2.instance.stageLock)
        {
            _stage2.SetActive(false);
        }
        if (Stage3.instance.stageLock)
        {
            _stage3.SetActive(false);
        }
        if (Stage4.instance.stageLock)
        {
            _stage4.SetActive(false);
        }
    }
}
