using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    [System.Serializable]
    public struct ButtonPlayerPrefs
    {
        public GameObject gameObject;
        public string playerPrefKey;
    }

    public ButtonPlayerPrefs[] buttons;
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
                    Debug.Log("Stars for level"+ (i+1)+ " Active");
                    star.gameObject.SetActive(true);
                }
                else
                {
                    star.gameObject.SetActive(false);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    
}
