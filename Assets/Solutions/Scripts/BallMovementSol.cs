using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This forces the designer to add a RigidBody2D
[RequireComponent (typeof(Rigidbody2D))]
public class BallMovementSol : MonoBehaviour {

	// the direction of the ball at instantiation
	public Vector3 initialVelocity;
	// reference to the rigidbody
	public Rigidbody2D rigidBody;
	// maximum speed of the ball
	public int maximumSpeed;
	// minimum angle of the ball's direction (to avoid flat trajectories) 
	[Range(0.0f, 45.0f)]
	public float minimumAngle;
	// minimum angle in radiants
	private float minimumAngleRad;
	// normalized X value for the minimum angle
	private float minAngleNormalizedX;
	// normalized X value for the minimum angle
	private float minAngleNormalizedY;


	// Use this for initialization
	void Start () {
		// 1. Get the Rigidbody component of the ball
		// Hint: https://docs.unity3d.com/ScriptReference/GameObject.GetComponent.html

		// test if rigidbody is already initialized
		if (!rigidBody) {
			// get the rigidbody attached to this GameObject
			rigidBody = GetComponent<Rigidbody2D> ();
			// if we can't find a rigidbody, there's a design error. Note that RequireComponent (see before class definition) already enforces this.
			if (!rigidBody) {
				Debug.LogError ("The object " + gameObject.name + "requires a Rigidbody2D Component to work properly");
			}
		}

		// 2. set the rigidbody's velocity
		// Hint: set Rigidbody2D.velocity https://docs.unity3d.com/ScriptReference/Rigidbody-velocity.html

		rigidBody.velocity = initialVelocity;

		// set minimum angle in radiants
		minimumAngleRad = Mathf.Deg2Rad * minimumAngle;

		// set normalized X and Y values
		minAngleNormalizedX = Mathf.Cos(minimumAngleRad);
		minAngleNormalizedY = Mathf.Sin (minimumAngleRad);

	}

	void Update () {
		LimitSpeed ();
		AdjustAngle ();
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
		// 3. Choose Vector2.Right or -Vector2.Right depending on ball right / left direction
		Vector2 horizontalRef = goesRight ? Vector2.right : Vector2.left;
		// 3. Get the angle between horizontal direction and the ball's direction
		float currentAngle =  Vector2.Angle(horizontalRef, rigidBody.velocity);
		// 4. Adjust velocity's angle if < minimumAngle
		if (currentAngle < minimumAngle) {
			// store the velocity's magnitude
			float currentSpeed = rigidBody.velocity.magnitude;
			// get target X and Y for new velocity
			float targetX = goesRight ? minAngleNormalizedX : -minAngleNormalizedX;
			float targetY = goesUp ? minAngleNormalizedY : -minAngleNormalizedY;
			// set velocity
			rigidBody.velocity = new Vector2(targetX, targetY) * currentSpeed;
		}

	}

}
