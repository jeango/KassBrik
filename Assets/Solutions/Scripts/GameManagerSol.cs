using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Manages the state of the game
public class GameManagerSol : MonoBehaviour {

    public RectTransform gameOverPanel;

    // Starts a new game
    public void NewGame()
    {
        //1. Reload the current scene
        // Hint: http://answers.unity3d.com/questions/1109479/how-to-reload-a-scene-using-scenemanager.html
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Displays Game Over screen
    public void GameOver()
    {
        //1. Display the GameOver UI
        // Hint: https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
        gameOverPanel.gameObject.SetActive(true);
    }
}
