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
    
}
