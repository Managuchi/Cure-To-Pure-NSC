using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InfoDisplay : MonoBehaviour
{
    public static bool infoIsDisplay;

    PlayerController playerController;
    Weapon weapon;

    public GameObject infoMenu;
    public GameObject infoPanel;

    public Profile profile;

    public Image artwork;
    public new TextMeshProUGUI name;
    public TextMeshProUGUI description;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        weapon = FindObjectOfType<Weapon>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (infoIsDisplay)
            {
                CloseProfileMenu();
                CloseProfile();
            }
        }
    }

    public void ShowProfileMenu()
    {
        playerController.enabled = false;
        weapon.enabled = false;

        infoMenu.SetActive(true);
        Time.timeScale = 0f;
        infoIsDisplay = true;
    }

    public void ShowProfile(Profile profile)
    {
        infoPanel.SetActive(true);
        artwork.sprite = profile.artwork;
        name.text = profile.name;
        description.text = profile.description;
    }

    public void CloseProfileMenu()
    {
        playerController.enabled = true;
        weapon.enabled = true;

        infoMenu.SetActive(false);
        Time.timeScale = 1f;
        infoIsDisplay = false;
    }

    public void CloseProfile()
    {
        infoPanel.SetActive(false);
    }
}
