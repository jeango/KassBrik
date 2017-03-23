using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyerSol : MonoBehaviour {

    public LivesManagerSol livesManager;

	void OnCollisionEnter2D(Collision2D col) {
		// 1. Destroy the colliding GameObject
		// Hint: https://docs.unity3d.com/Manual/CreateDestroyObjects.html
		Destroy(col.gameObject);

        // 2. Lose life
        livesManager.LoseLife();

	}
}
