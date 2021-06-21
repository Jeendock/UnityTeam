using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUI : MonoBehaviour
{
    public GameObject ingameMenu;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            ButtonOptionClicked();
    }

    public void ButtonOptionClicked()
    {
        if (ingameMenu.activeSelf == false)
        {
            ingameMenu.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else
        {
            ingameMenu.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

    public void GoMainMenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
}