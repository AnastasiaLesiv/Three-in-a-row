using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        PlayerPrefs.SetInt("Level 1", 0);
        PlayerPrefs.SetInt("Level 2", 0);
        PlayerPrefs.SetInt("Level 3", 0);
        SceneManager.LoadScene("LevelSelect");
    }

    public void ExitGame()
    {
        Debug.Log("Game over");
        //Application.Quit();
    }
}
