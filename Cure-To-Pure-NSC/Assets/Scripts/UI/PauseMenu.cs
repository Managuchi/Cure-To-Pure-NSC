using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public System.Action OnGamePaused;

    public static bool gameIsPaused;

    public GameObject pauseMenuUI;
    PlayerController playerController;
    Weapon weapon;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        weapon = FindObjectOfType<Weapon>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !InfoDisplay.infoIsDisplay)
        {
            if (!gameIsPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    public void Pause()
    {
        playerController.enabled = false;
        weapon.enabled = false;

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Resume()
    {
        playerController.enabled = true;
        weapon.enabled = true;

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void RestartScene()
    {
        Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("Home");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
