using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{

    public String mainSceneStr;
    
    public void QuitTheGame()
    {
        Application.Quit();
    }

    public void StartTheGame()
    {
        // Leads into main game scene
        SceneManager.LoadScene(mainSceneStr);
    }
    
    
}
