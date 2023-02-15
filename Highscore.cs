using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text highscoretext;

    void Start()
    {
        highscoretext.text = "Highscore : " + PlayerPrefs.GetInt("Highscore");
    }
}
