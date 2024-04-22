using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Pause()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void Quit(string nameScene)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nameScene);
    }

    public void Save()
    {
        string saveData = PlayerPrefs.GetInt("Player", 0) + "," + PlayerPrefs.GetInt("Level 1", 0)
                          + "," + PlayerPrefs.GetInt("Level 2", 0) + "," + PlayerPrefs.GetInt("Level 3", 0);
        string name = PlayerPrefs.GetString("currentName", String.Empty);
        PlayerPrefs.SetString(name, saveData);
        PlayerPrefs.Save();
    }
    
}
