using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class UITraveral
{
    public static void LoadLevelSelectorScene()
    {
        SceneManager.LoadScene("LevelSelector");
    }

    public static void LoadAboutScene()
    {
        SceneManager.LoadScene("About");
    }

    public static void LoadMainMenuScene()
    {
        SceneManager.LoadScene("Home");
    }

    public static void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
