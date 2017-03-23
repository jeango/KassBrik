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
		// 2. Destroy (Hint: https://docs.unity3d.com/Manual/CreateDestroyObjects.html)
		Destroy(gameObject);
	}
}
