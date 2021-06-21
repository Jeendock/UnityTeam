using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUI : MonoBehaviour
{
    public GameObject ingameMenu;

    private void Start()
    {
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
            ingameMenu.SetActive(true);
        else
            ingameMenu.SetActive(false);
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}