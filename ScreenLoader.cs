using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public void LoadStage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void LoadStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
       
}
