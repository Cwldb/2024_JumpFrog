using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class VolumeController : MonoBehaviour
{
    public Slider _volumeSlider;
    
    private void Awake()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            _volumeSlider.value = PlayerPrefs.GetFloat("Volume");
        }
        else
        {
            _volumeSlider.value = 0.5f;
        }
    }

    void Start()
    {
        _volumeSlider.value = AudioManager.instance.GetComponent<AudioSource>().volume;
        _volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        PlayerPrefs.SetFloat("Volume", volume);
        AudioManager.instance.SetVolume(volume);
    }






    //// Start is called before the first frame update
    //void Start()
    //{
    //    slider.onValueChanged.AddListener(OnValueChanged);
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    //public void OnValueChanged(float _value)
    //{
    //    textValue.text = _value.ToString("F");
    //    // Save 
    //    PlayerPrefs.SetFloat("Volume", _value);
    //}
}
