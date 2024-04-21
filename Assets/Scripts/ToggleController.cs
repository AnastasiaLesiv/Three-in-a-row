using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
    public string toggleKey = "ToggleState";
    public AudioSource audioSource;
    public Toggle toggle;

   
    private void OnDisable()
    {
        PlayerPrefs.SetInt(toggleKey, toggle.isOn ? 1 : 0); 
        // Збереження стану toggle в PlayerPrefs.
    }

    private void Awake()
    {
      
        toggle.isOn = PlayerPrefs.GetInt(toggleKey, 1) == 1;
       
        toggle.onValueChanged.AddListener(HandleToggleValueChanged);
        
        var audioSource = FindObjectOfType<AudioSource>();
        if (audioSource != null)
        {
            // Встановлення посилання toggle на поточний AudioSource
            HandleToggleValueChanged(toggle.isOn);
        }
        else
        {
            Debug.LogWarning("No AudioSource found in the scene.");
        }
    }

    
    void HandleToggleValueChanged(bool value)
    {
        
        PlayerPrefs.SetInt(toggleKey, value ? 1 : 0);
       
        var audioSource = FindObjectOfType<AudioSource>();
        
        if (audioSource != null)
        {
            // Встановлення стану звукового джерела відповідно до значення toggle
            audioSource.enabled = value;
        }
        else
        {
            Debug.LogWarning("No AudioSource found in the scene.");
        }
    }

    void Start()
    {
        // Встановлення стану звукового джерела відповідно до стану toggle при запуску.
        HandleToggleValueChanged(toggle.isOn);
    }
}