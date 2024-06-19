using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundSettingUI : MonoBehaviour
{
    public AudioSource bgm;
    public AudioSource jump;

    public void SetMusicVolume(float volume)
    {
        bgm.volume = volume;
    }

    public void SetJumpVolume(float volume)
    {
        jump.volume = volume;
    }
}
