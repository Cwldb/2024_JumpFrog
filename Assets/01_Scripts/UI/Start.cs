using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start : MonoBehaviour
{
    [SerializeField] private GameObject _soundPanel;

    public void SceneChange()
    {
        SceneManager.LoadScene("SelectStage");
    }

    public void SettingUI()
    {
        _soundPanel.SetActive(true);
    }

    public void SettingUIFalse()
    {
        _soundPanel.SetActive(false);
    }

    public void GuideScene()
    {
        SceneManager.LoadScene("Guide");
    }

    public void Quitgame()
    {
        print("게임 종료");
        Application.Quit();
    }
}
