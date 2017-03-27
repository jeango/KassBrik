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
    // Reference to the game manager
    public GameManager gameManager;

    // We have to initialize scoreManager and gameManager in the Start method because bricks could be instantiated instead of placed on the scene manually
    void Start()
    {
        // 1. if game manager is not initialized, find it on the scene and initialize it
        // Hint: https://docs.unity3d.com/ScriptReference/Object.FindObjectOfType.html

        // 2. if no game manager found, send an error message
        // Hint: https://docs.unity3d.com/ScriptReference/Debug.LogError.html

        // 3. Do the same for score manager
    }

    // This Function Event is called whenever an object collides with this object
    void OnCollisionEnter2D(Collision2D col)
    {
        // Take damage
        TakeDamage(1);
    }

    public void TakeDamage(int damage)
    {
        // 1. Reduce health
        // 2. Call Die if health <= 0
    }

    public void Die()
    {
        // 1. Update the score

        // 2. if there are no more bricks remaining on the scene, call Win() on the game manager
        // Hint: https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html

        // 3. Destroy the brick (Hint: https://docs.unity3d.com/Manual/CreateDestroyObjects.html)

    }

}


