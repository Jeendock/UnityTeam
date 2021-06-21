using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour
{
    public GameObject[] button;
    public GameObject exitMenu;
    public GameObject optionMenu;

    public void ButtonStartClicked()
    {
        SceneManager.LoadScene("DoorRoom");
    }

    public void ButtonOptionClicked()
    {
        optionMenu.SetActive(true);
    }

    public void ButtonCloseClicked()
    {
        optionMenu.SetActive(false);
    }

    public void ButtonExitClicked()
    {
        exitMenu.SetActive(true);
    }

    public void ButtonYesClicked()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                    Application.Quit();
#endif
    }

    public void ButtonNoClicked()
    {
        exitMenu.SetActive(false);
    }
}