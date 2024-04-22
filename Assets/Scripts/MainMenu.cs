using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField nameText;
    private string name;
    public void PlayGame()
    {
        string[] names;
        name = nameText.text;
        Debug.Log(name);
        if (PlayerPrefs.HasKey("names"))
        {
            Debug.Log("Key names here");
            string namesString = PlayerPrefs.GetString("names", String.Empty);
            if (namesString != String.Empty)
            {
                Debug.Log("Key names is not empty");
                names = namesString.Split(",");
                foreach (var itemName in names)
                {
                    string tempName = name;
                    string tempItemName = itemName;
                    if (tempItemName.ToLower().CompareTo( tempName.ToLower()) == 0)
                    {
                        Debug.Log("Current name is in names");
                        if (PlayerPrefs.HasKey(name))
                        {
                            Debug.Log("Key name is here");
                            string nameValues = PlayerPrefs.GetString(itemName, String.Empty);
                            if (nameValues != String.Empty)
                            {
                                Debug.Log("Name string is not empty");
                                string[] values = nameValues.Split(",");
                                PlayerPrefs.SetInt("Player", Convert.ToInt32(values[0]));
                                PlayerPrefs.SetInt("Level 1", Convert.ToInt32(values[1]));
                                PlayerPrefs.SetInt("Level 2", Convert.ToInt32(values[2]));
                                PlayerPrefs.SetInt("Level 3", Convert.ToInt32(values[3]));
                                break;
                            }
                            else
                            {
                                Debug.Log("Name string is empty");
                                PlayerPrefs.SetInt("Player", 0);
                                PlayerPrefs.SetInt("Level 1", 0);
                                PlayerPrefs.SetInt("Level 2", 0);
                                PlayerPrefs.SetInt("Level 3", 0);
                            }
                        }
                        else
                        {
                            Debug.Log("Key name is not here");
                            PlayerPrefs.SetInt("Player", 0);
                            PlayerPrefs.SetInt("Level 1", 0);
                            PlayerPrefs.SetInt("Level 2", 0);
                            PlayerPrefs.SetInt("Level 3", 0);
                        }
                    }
                    else
                    {
                        Debug.Log("Current name is not in names");
                        namesString += itemName + ",";
                        PlayerPrefs.SetString("names", namesString);
                        PlayerPrefs.SetInt("Player", 0);
                        PlayerPrefs.SetInt("Level 1", 0);
                        PlayerPrefs.SetInt("Level 2", 0);
                        PlayerPrefs.SetInt("Level 3", 0);
                    }
                }
            }
            else
            {
                Debug.Log("Key names is empty");
                PlayerPrefs.SetString("names", name + ",");
                PlayerPrefs.SetInt("Player", 0);
                PlayerPrefs.SetInt("Level 1", 0);
                PlayerPrefs.SetInt("Level 2", 0);
                PlayerPrefs.SetInt("Level 3", 0); 
            }
            
        }
        else
        {
            Debug.Log("Key names not here");
            PlayerPrefs.SetString("names", name + ",");
            PlayerPrefs.SetInt("Player", 0);
            PlayerPrefs.SetInt("Level 1", 0);
            PlayerPrefs.SetInt("Level 2", 0);
            PlayerPrefs.SetInt("Level 3", 0); 
        }
        PlayerPrefs.SetString("currentName", name);
        SceneManager.LoadScene("LevelSelect");
    }

    public void ExitGame()
    {
        Debug.Log("Game over");
        //Application.Quit();
    }
}
