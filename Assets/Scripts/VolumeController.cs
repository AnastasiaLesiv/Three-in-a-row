using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public string volumeParameter = "MasterVolume";
    public AudioMixer mixer;
    public Slider slider;
    private float volumeValue;
    private const float _multiplier = 20f;
    // Start is called before the first frame update
    void Start()
    {
        volumeValue = PlayerPrefs.GetFloat(volumeParameter, Mathf.Log10(slider.value) * _multiplier);
        mixer.SetFloat(volumeParameter, volumeValue);
        slider.value = Mathf.Pow(10f, volumeValue / _multiplier);
    }

    private void Awake()
    {
        slider.onValueChanged.AddListener(HandleSliderValueChanged);
        mixer.SetFloat(volumeParameter, volumeValue);
    }

    private void HandleSliderValueChanged(float value)
    {
        volumeValue = Mathf.Log10(value) * _multiplier;
        mixer.SetFloat(volumeParameter, volumeValue);
    }

    // Update is called once per frame

   
    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volumeParameter, volumeValue);
    }
}
