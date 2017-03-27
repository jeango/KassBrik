using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    // the prefab to instantiate
    public GameObject ballPrefab;

    // Used for initialization
    void Start()
    {
        // Spawn a ball when the game starts
        SpawnBall();
    }

    public void SpawnBall()
    {
        // Instantiate a new ball at the position of the spawner object
        // Hint: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
    }
}
