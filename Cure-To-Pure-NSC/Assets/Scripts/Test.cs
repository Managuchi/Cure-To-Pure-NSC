using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Profile bacteria;
    public Profile wbc;

    public GameObject onPlayUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            onPlayUI.GetComponent<InfoDisplay>().profile = bacteria;
            onPlayUI.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            onPlayUI.GetComponent<InfoDisplay>().profile = wbc;
            onPlayUI.SetActive(true);
        }

        if (onPlayUI.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                onPlayUI.SetActive(false);
            }
        }
    }
}
