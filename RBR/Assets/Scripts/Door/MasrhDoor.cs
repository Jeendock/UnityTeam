using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasrhDoor : MonoBehaviour
{
    public GameObject Select;

    private void Start()
    {
        Select.SetActive(false);
    }

    private void Update()
    {
        if (Select.gameObject.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SceneManager.LoadScene("BossRoom2");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Select.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Select.SetActive(false);
        }
    }
}