﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Manages the state of the game
public class GameManagerSol : MonoBehaviour {

    // Reference to the game over UI
    public RectTransform gameOverPanel;
    // Reference to the win UI
    public RectTransform winPanel;

    // Starts a new game
    public void NewGame()
    {
        //1. Reload the current scene
        // Hint: http://answers.unity3d.com/questions/1109479/how-to-reload-a-scene-using-scenemanager.html
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //2. Unpause the game
        Time.timeScale = 1;
    }

    // Displays Game Over screen
    public void GameOver()
    {
        //1. Display the GameOver UI
        // Hint: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
        gameOverPanel.gameObject.SetActive(true);
        //2. Pause the game
        Time.timeScale = 0;
    }

    // Displays Win screen
    public void Win()
    {
        //1. Display the Win UI
        winPanel.gameObject.SetActive(true);
        //2. Pause the game
        Time.timeScale = 0;
    }

}
