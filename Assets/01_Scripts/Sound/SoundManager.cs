using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public AudioSource bgm;
    public AudioSource jumpSound;
    //public AudioClip jumpClip;

    private bool destroy;
    public bool isPlaying = false;

    public static SoundManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);

        }

        //var soundManagers = FindObjectsOfType<SoundManager>();

        //if (soundManagers.Length == 1)
        //{
        //    DontDestroyOnLoad(gameObject);
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}

    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    public void Start()
    {
        bgm.Play();
    }

    public void PlayJumpSound()
    {
        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            jumpSound.Play();
        }
        else if (SceneManager.GetActiveScene().name == "Stage3")
        {
            jumpSound.Play();
        }
        else if (SceneManager.GetActiveScene().name == "Stage2")
        {
            jumpSound.Play();
        }
        else if (SceneManager.GetActiveScene().name == "Stage1")
        {
            jumpSound.Play();
        }

    }

}
