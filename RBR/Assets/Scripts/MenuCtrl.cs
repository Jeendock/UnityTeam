using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour
{
    public GameObject[] button;
    public GameObject select;

    public void ButtonStartClicked()
    {
        SceneManager.LoadScene("DoorRoom");
    }

    public void ButtonOptionClicked()
    {
        // 블라 블라~;
    }

    public void ButtonExitClicked()
    {
        select.SetActive(true);
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
        select.SetActive(false);
    }
}