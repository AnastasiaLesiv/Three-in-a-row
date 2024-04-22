using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelect : MonoBehaviour
{
    [System.Serializable]
    public struct ButtonPlayerPrefs
    {
        public GameObject gameObject;
        public string playerPrefKey;
    }

    public ButtonPlayerPrefs[] buttons;
   // public Dictionary<string, Dictionary<string, int>> storageData;
    void Start()
    {

        for (int i = 0; i < buttons.Length; i++)
        {
            int score = PlayerPrefs.GetInt(buttons[i].playerPrefKey, 0);
            for (int starIdx = 1; starIdx <= 3; starIdx++)
            {
                Transform star = buttons[i].gameObject.transform.Find("Star_" + starIdx);
                if (starIdx <= score)
                {
                    star.gameObject.SetActive(true);
                }
                else
                {
                    star.gameObject.SetActive(false);
                }
            }
        }
        int playerBestResult = PlayerPrefs.GetInt("Player", 0);
        int newResult = PlayerPrefs.GetInt("Level 1", 0) + PlayerPrefs.GetInt("Level 2", 0) +
                        PlayerPrefs.GetInt("Level 3", 0);
        if (newResult > playerBestResult)
        {
            PlayerPrefs.SetInt("Player", newResult);
        }
    }

    public void OnButtonPress(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    
}
