using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private static bool _gameIsPaused = false;

    public GameObject pauseMenuUI;
    public string mainMenuSceneName = "MainMenu";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        _gameIsPaused = false;
    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        _gameIsPaused = true;
    }
    
    public void OptionsMenu()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(mainMenuSceneName);
        StartCoroutine(OpenOptionsAfterSceneLoad());
    }
    
    private IEnumerator OpenOptionsAfterSceneLoad()
    {
        yield return null;

        MainMenu mainMenu = FindObjectOfType<MainMenu>();
        if (mainMenu != null)
        {
            mainMenu.OpenOptions();
        }
        else
        {
            Debug.LogError("MainMenu not found!");
        }

        Time.timeScale = 1f;
    }


    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
