using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyerSol : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {
		// Destroy the colliding GameObject
		// Hint: https://docs.unity3d.com/Manual/CreateDestroyObjects.html
		Destroy(col.gameObject);
	}
}
