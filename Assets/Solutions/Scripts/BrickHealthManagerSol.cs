using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickHealthManagerSol : MonoBehaviour {

	// This is the health of the object
	public int health;
	// How many points do we gain when this object dies
	public int score;
	// Reference to the score manager
	public ScoreManagerSol scoreManager;
    // Reference to the game manager
    public GameManagerSol gameManager;

    // Use this for initialization
    void Start()
    {
        // if game manager is not initialized, find it on the scene and initialize it
        gameManager = (GameManagerSol)GameObject.FindObjectOfType<GameManagerSol>();
        // if still not initialized, send an error message
        if (!gameManager)
        {
            Debug.LogError("There needs to be at least one GameManager object on the scene");
        }
        // if score manager is not initialized, find it on the scene and initialize it
        scoreManager = (ScoreManagerSol)GameObject.FindObjectOfType<ScoreManagerSol>();
        // if still not initialized, send an error message
        if (!scoreManager)
        {
            Debug.LogError("There needs to be at least one GameManager object on the scene");
        }
    }

    // This Function Event is called whenever an object collides with this object
	void OnCollisionEnter2D(Collision2D col) {
		// Take damage
		TakeDamage (1);

		// Note: we could also add a "Damage" component to the Ball, and get the damage value instead of a hardcoded 1 damage
		/*
		 * Damage damageComponent = col.gameObject.GetComponent<Damage>();
		 * if(Damage) TakeDamage(Damage.damageAmount);
		 * else TakeDamage(1);
		*/

		}

	public void TakeDamage(int damage) {
		// 1. Reduce health
		health -= damage;
		// 2. Call Die if health <= 0
		if (health <= 0) Die();
	}

	public void Die() {
		// 1. Update the score
		scoreManager.GainPoints(score);
        //2. if there are no more bricks remaining on the scene, call Win() on the game manager
        // Hint: https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
        if (GameObject.FindGameObjectsWithTag("Brick").Length <= 1)
            gameManager.Win();
        // 3. Destroy (Hint: https://docs.unity3d.com/Manual/CreateDestroyObjects.html)
		Destroy(gameObject);
	}
}
