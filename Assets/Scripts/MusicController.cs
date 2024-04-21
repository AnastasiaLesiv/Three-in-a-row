using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public string volumeParameter = "masterVolume";
    public AudioMixer mixer;
    public Slider slider;
    private const float multiplier = 20f;
    private float volumeValue;

    void Awake()
    {
        slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void HandleSliderValueChanged(float value)
    {
        volumeValue = Mathf.Log10(value) * multiplier;
        mixer.SetFloat(volumeParameter, volumeValue);
    }
    void Start()
    {
        volumeValue = PlayerPrefs.GetFloat(volumeParameter, Mathf.Log10(slider.value) * multiplier);
        slider.value = Mathf.Pow(10f, volumeValue / multiplier);
    }


    // Update is called once per frame
    void Update()
    {
        //volumeValue = PlayerPrefs.GetFloat(volumeParameter, Mathf.Log10(slider.value) * multiplier);
        slider.value = Mathf.Pow(10f, volumeValue /multiplier);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volumeParameter, volumeValue);
    }
}