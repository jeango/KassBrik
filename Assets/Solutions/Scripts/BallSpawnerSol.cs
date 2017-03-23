using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerSol : MonoBehaviour {

    public GameObject ballPrefab;

    // Used for initialization
    void Start()
    {
        SpawnBall();   
    }

    public void SpawnBall()
    {
        Instantiate(ballPrefab, transform.position, Quaternion.identity);
    }
}
