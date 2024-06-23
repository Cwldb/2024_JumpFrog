using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAManager : MonoBehaviour
{
    public static JumpAManager instance;
    public AudioSource _audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            _audioSource = GetComponent<AudioSource>();
        }

        else
        {
            Destroy(gameObject);
        }

    }

    public void SetVolume(float volume)
    {
        _audioSource.volume = volume;
    }
}
