using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc : MonoBehaviour
{
    private EscPanel _escP;
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _checkPanel;

    private void Awake()
    {
        _escP = FindAnyObjectByType<EscPanel>();
    }

    public void CheckStart()
    {
        _checkPanel.SetActive(true);
    }

    public void NotCheckStart()
    {
        _checkPanel.SetActive(false);
    }

    public void StartScene()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
    }

    public void SelectStage()
    {
        SceneManager.LoadScene("SelectStage");
        Time.timeScale = 1f;
        EscPanel.instance._isEsc = true;
    }

    public void TurnBackScreen()
    {
        _escP._isEsc = false;
        _panel.SetActive(false);
        Time.timeScale = 1f;
    }
}
