using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guide : MonoBehaviour
{
    public void TurnBackMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
