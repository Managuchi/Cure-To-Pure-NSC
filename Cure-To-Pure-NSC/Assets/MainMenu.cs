using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadLevelSelectorScene()
    {
        SceneManager.LoadScene("LevelSelector");
    }

    public void LoadAboutScene()
    {
        SceneManager.LoadScene("About");
    }
}
