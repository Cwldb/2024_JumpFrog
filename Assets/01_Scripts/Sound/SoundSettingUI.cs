using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettingUI : MonoBehaviour
{
    public AudioSource bgm;
    public AudioSource jump;

    [SerializeField] private Slider slider;
    [SerializeField] private SoundSO setting;

    private void Update()
    {
        bgm.volume = slider.value;
        setting.BGMSound = bgm.volume;
    }

    public void BGM_Slider(float Value)
    {
        setting.BGMSound = Value;
    }

    public void SetMusicVolume(float value)
    {
        bgm.volume = value;
    }

    public void SetJumpVolume(float volume)
    {
        jump.volume = volume;
    }
}
