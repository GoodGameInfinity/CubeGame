using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject EscapePanel;

    public void SaveShowFPS(bool value)
    {
        SaveSettings.IsShowFPS = value;
    }


    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void ExitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void ReastartLevel(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void OpenEscape(bool value)
    {
        EscapePanel.SetActive(value);
    }

}
