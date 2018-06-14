﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

    public static bool GamePaused = false;

    public GameObject pauseMenuUI;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
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
        GamePaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void LoadMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Menu Loaded!");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit!");
    }
}
