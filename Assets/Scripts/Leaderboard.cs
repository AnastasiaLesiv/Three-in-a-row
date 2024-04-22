using System;
using TMPro;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class Leaderboard : MonoBehaviour
    {
        public TMP_Text[] players;
        public TMP_Text[] scores;
        public void InitializationBoard()
        {
            
            /*string namesString = PlayerPrefs.GetString("names", String.Empty);
            if (namesString != String.Empty)
            {
                string[] namesArr = namesString.Split(",");
                for (int i = 0; i < namesArr.Length; i++)
                {
                    players[i].text = namesArr[i];
                    scores[i].text = PlayerPrefs.GetInt(namesArr[i], 0).ToString();
                }
                
            }*/
        }
        
    }
