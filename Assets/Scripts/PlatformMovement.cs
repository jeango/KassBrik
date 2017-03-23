using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

	// The movement speed of the platform
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Call Move every frame
		Move();
	}

	// Implement the platform movement here
	void Move () {
		// Get Input from keyboard
		// Hint: https://docs.unity3d.com/ScriptReference/Input.GetAxis.html

		// Move the platform
		// Hint: https://docs.unity3d.com/ScriptReference/Transform.Translate.html

	}
}
