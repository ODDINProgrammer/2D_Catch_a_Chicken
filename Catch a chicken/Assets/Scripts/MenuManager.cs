using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField] private GameObject _menu;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    private void PauseGame()
    {
        GameIsPaused = !GameIsPaused;
        if (GameIsPaused)
        {
            _menu.SetActive(!_menu.activeSelf);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            _menu.SetActive(!_menu.activeSelf);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }
    }
    public void Continue()
    {
        PauseGame();
    }
}
