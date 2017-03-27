using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyerSol : MonoBehaviour {

    // Reference to the lives manager object
    public LivesManagerSol livesManager;

     void Start()
    {
        // 1. If livesManager is not initialized, find the lives manager on the scene
        // Hint: https://docs.unity3d.com/ScriptReference/Object.FindObjectOfType.html
        if (!livesManager)
        {
            // Note: we have to do an explicit type cast because "FindObjectOfType" returns an Object and not a LivesManager
            livesManager = (LivesManagerSol)GameObject.FindObjectOfType<LivesManagerSol>();
        }
        // 2. If it is still not initialized, then display an error on the console
        // Hint: https://docs.unity3d.com/ScriptReference/Debug.LogError.html
        if (!livesManager)
        {
            Debug.LogError("There needs to be at least one active LivesManager object on the scene");
        }
    }


    void OnCollisionEnter2D(Collision2D col) {
		// 1. Destroy the colliding GameObject
		// Hint: https://docs.unity3d.com/Manual/CreateDestroyObjects.html
		Destroy(col.gameObject);

        // 2. Lose life by calling "LoseLife" on the lives manager object
        livesManager.LoseLife();

	}
}
