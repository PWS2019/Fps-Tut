using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDIED : MonoBehaviour
{
    private void Start()
    {
        OnDisable();
     }

    public void RetryGame()
    {
        SceneManager.LoadScene(1);
        GlobalHealth.PlayerHealth = 100;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}