using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickHealthManager : MonoBehaviour {

	// This is the health of the object
	public int health;
	// How many points do we gain when this object dies
	public int score;
	// Reference to the score manager
	public ScoreManager scoreManager;

	// This Function Event is called whenever an object collides with this object
	void OnCollisionEnter2D(Collision2D col) {
		// Take Damage
	}

	public void TakeDamage(int damage) {
		// 1. Reduce health
		// 2. Check if health <=0
		// 3. Call Die if necessary
	}

	public void Die() {
		// 1. Update the score
		// 2. Destroy (Hint: https://docs.unity3d.com/Manual/CreateDestroyObjects.html)
	}


}
