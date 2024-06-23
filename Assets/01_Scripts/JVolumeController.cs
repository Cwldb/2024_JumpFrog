using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JVolumeController : MonoBehaviour
{
    public Slider _volumeSlider;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("JVolume"))
        {
            _volumeSlider.value = PlayerPrefs.GetFloat("JVolume");
        }
        else
        {
            _volumeSlider.value = 0.5f;
        }
    }

    void Start()
    {
        _volumeSlider.value = JumpAManager.instance.GetComponent<AudioSource>().volume;
        _volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        PlayerPrefs.SetFloat("JVolume", volume);
        JumpAManager.instance.SetVolume(volume);
    }
}
