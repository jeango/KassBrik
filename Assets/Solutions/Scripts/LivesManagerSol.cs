using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Manages the lives of the player
public class LivesManagerSol : MonoBehaviour {

    // The initial amount of lives when a game begins
    public int initialLives;
    // The current amount of lives
    public int currentLives;
    // A reference to the game manager
    public GameManagerSol gameManager;
    // A reference to the lives UI
    public Text livesUI;
    // A reference to the Ball Spawner
    public BallSpawnerSol ballSpawner;

	// Use this for initialization
	void Start () {
        //1. Initialize currentlives
        currentLives = initialLives;
        //2. Update UI text
        livesUI.text = "" + currentLives;	
	}

    public void LoseLife() {
        // 1. Decrement current lives
        currentLives--;
        // 2. Update lives UI text
        livesUI.text = "" + currentLives;
        // 3. If we still have lives, spawn a new ball
        if (currentLives > 0) ballSpawner.SpawnBall();
        // 4. If we have no more lives, call GameOver on the GameManager
        else gameManager.GameOver();
    }

}
