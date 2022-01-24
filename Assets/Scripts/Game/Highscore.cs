using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text save1, save2, save3, save4, save5, save6, save7, save8, save9, save10;
    public static int score;
    int highscore;
    int maxHighscores = 10;

    int newScore;
    int oldScore;


    void Start()
    {
        newScore = Score.GetScore();
        for (int i = 1; i <= maxHighscores; i++)
        {
            if (PlayerPrefs.HasKey(i + "HScore"))
            {
                if (PlayerPrefs.GetInt(i + "HScore") < newScore)
                {
                    oldScore = PlayerPrefs.GetInt(i + "HScore");
                    PlayerPrefs.SetInt(i + "HScore", newScore);
                    newScore = oldScore;
                }
            }
            else
            {
                PlayerPrefs.SetInt(i + "HScore", newScore);
                newScore = 0;
            }
        }
    }
    
    void LateUpdate()
    {
        for (int i = 1; i <= maxHighscores; i++)
        {
            switch (i)
            {
                case 1:
                    save1.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
                case 2:
                    save2.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
                case 3:
                    save3.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
                case 4:
                    save4.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
                case 5:
                    save5.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
                case 6:
                    save6.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
                case 7:
                    save7.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
                case 8:
                    save8.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
                case 9:
                    save9.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
                case 10:
                    save10.text = (i).ToString() + ": " + PlayerPrefs.GetInt(i + "HScore");
                    break;
            }
        }
    }

}
