using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EscPanel : MonoBehaviour
{

    [SerializeField] private GameObject _panel;

    public static EscPanel instance;
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
    public bool _isEsc;

    void Update()
    {
        if (!_isEsc)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                _isEsc = true;
                _panel.SetActive(true);
                Time.timeScale = 0;
            }
        }

        else if (_isEsc)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                _isEsc = false;
                _panel.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
