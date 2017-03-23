using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlatformMovementSol : MonoBehaviour {

	// The movement speed of the platform
	public float speed;
	public Rigidbody2D rigidBody;

	// Update is called once per frame
	// Note: we use FixedUpdate instead because we want more precise collisions. FixedUpdate is called at each Physical update (which can be several times per frame)
	void FixedUpdate () {
		// Call Move every frame
		Move();
	}

	// Implement the platform movement here
	void Move () {
		// Get Input from keyboard
		// Hint: https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
		float horizontalSpeed = Input.GetAxisRaw("Horizontal") * speed;   // We multiply the speed by the calculation time of the fixed update. This allows for smooth movement.

		// Move the platform
		// Hint: https://docs.unity3d.com/ScriptReference/Transform.Translate.html
		rigidBody.velocity = transform.right * horizontalSpeed;

	}
}
