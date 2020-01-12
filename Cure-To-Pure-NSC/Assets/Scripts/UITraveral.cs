using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITraveral : MonoBehaviour
{
    public void LoadLevelSelectorScene()
    {
        SceneManager.LoadScene("LevelSelector");
    }

    public void LoadAboutScene()
    {
        SceneManager.LoadScene("About");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("Home");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
