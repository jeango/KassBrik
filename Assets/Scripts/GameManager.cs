using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // Reference to the game over UI
    public RectTransform gameOverPanel;
    // Reference to the win UI
    public RectTransform winPanel;

    // Starts a new game
    public void NewGame()
    {
        //1. Reload the current scene
        // Hint: http://answers.unity3d.com/questions/1109479/how-to-reload-a-scene-using-scenemanager.html
        //2. Unpause the game
    }

    // Displays Game Over screen
    public void GameOver()
    {
        //1. Display the GameOver UI
        // Hint: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
        //2. Pause the game
    }

    // Displays Win screen
    public void Win()
    {
        //1. Display the Win UI
        //2. Pause the game
    }
}
