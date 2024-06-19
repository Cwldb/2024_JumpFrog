using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc : MonoBehaviour
{
    private EscPanel _escP;
    [SerializeField] private GameObject _panel;

    private void Awake()
    {
        _escP = FindAnyObjectByType<EscPanel>();
    }

    public void StartScene()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale  = 1f;
    }

    public void TurnBackScreen()
    {
        _escP._isEsc = false;
        _panel.SetActive(false);
        Time.timeScale = 1f;
    }
}
