using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour {

    // The initial amount of lives when a game begins
    public int initialLives;
    // The current amount of lives
    public int currentLives;
    // A reference to the game manager
    public GameManager gameManager;
    // A reference to the lives UI
    public Text livesUI;
    // A reference to the Ball Spawner
    public BallSpawner ballSpawner;

    // Use this for initialization
    void Start()
    {
        //1. Initialize currentlives
        //2. Update UI text
    }

    public void LoseLife()
    {
        // 1. Reduce current lives by 1
        // 2. Update lives UI text
        // 3. If we still have lives, spawn a new ball with the ball spawner
        // 4. If we have no more lives, call GameOver on the GameManager
    }
}
