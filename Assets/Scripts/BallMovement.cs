using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Ball movement makes sure the ball has an initial velocity. The rest of the ball movement will be managed by game physics
/// </summary>
public class BallMovement : MonoBehaviour {

	// the velocity (direction and speed) of the ball at instantiation
	public Vector3 initialVelocity;
	// reference to the rigidbody
	public Rigidbody2D rigidBody;
	// maximum speed of the ball
	public int maximumSpeed;
	// minimum angle of the ball's direction (to avoid flat trajectories) 
	[Range(0.0f, 45.0f)]
	public float minimumAngle;

	// Use this for initialization
	void Start () {
		// 1. Get the Rigidbody component of the ball
		// Hint: https://docs.unity3d.com/ScriptReference/GameObject.GetComponent.html

		// 2. set the rigidbody's velocity
		// Hint: set Rigidbody2D.velocity https://docs.unity3d.com/ScriptReference/Rigidbody-velocity.html
	}

	void Update () {
		LimitSpeed ();
	}

	// Optional exercice: Make sure the speed does not exceed max speed
	void LimitSpeed() {
		// 1. check if velocity's magnitude is greater than maximum speed
		if (rigidBody.velocity.magnitude > maximumSpeed) 
			// 2. adjust velocity if needed
			rigidBody.velocity = rigidBody.velocity.normalized * maximumSpeed;
	}

	// Optional exercice: Make sure the angle of the ball's movement is higher than the minimum angle
	void AdjustAngle() {
		// 1. Is ball moving up or down?
		bool goesUp = rigidBody.velocity.y >= 0;
		// 2. Is ball moving right or left?
		bool goesRight = rigidBody.velocity.x >= 0;
		// 3. Get the angle between horizontal direction and the ball's direction
		float currentAngle =  Vector2.Angle(Vector2.right, rigidBody.velocity);
		print (currentAngle);
		// 4. Check if angle is within the bounds

	}

	void OnCollisionEnter2D(Collision2D col) {
		AdjustAngle ();
	}


}
