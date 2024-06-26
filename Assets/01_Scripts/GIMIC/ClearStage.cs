using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ClearStage : MonoBehaviour
{
    [SerializeField] private GameObject _clearPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _clearPanel.SetActive(true);
            Time.timeScale = 0;
            EscPanel.instance._isEsc = false;
        }
    }
}
