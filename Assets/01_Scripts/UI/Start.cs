using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("SelectStage");
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
