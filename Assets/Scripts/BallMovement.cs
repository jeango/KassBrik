using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This forces the designer to add a RigidBody2D
[RequireComponent(typeof(Rigidbody2D))]
public class BallMovement : MonoBehaviour
{

    // the direction of the ball at instantiation
    public Vector3 initialVelocity;
    // reference to the rigidbody
    public Rigidbody2D rigidBody;
    // maximum speed of the ball
    public int maximumSpeed;
    // minimum angle of the ball's direction (to avoid flat trajectories) 
    [Range(0.0f, 45.0f)] // this restraints the value of the property in the inspector
    public float minimumAngle;
    // minimum angle in radiants
    private float minimumAngleRad;
    // normalized X value for the minimum angle
    private float minAngleNormalizedX;
    // normalized X value for the minimum angle
    private float minAngleNormalizedY;


    // Use this for initialization
    void Start()
    {
        // 1. Get the Rigidbody component of the ball
        // Hint: https://docs.unity3d.com/ScriptReference/GameObject.GetComponent.html

        // test if rigidbody is already initialized
        if (!rigidBody)
        {
            // get the rigidbody attached to this GameObject
            rigidBody = GetComponent<Rigidbody2D>();
            // if we can't find a rigidbody, there's a design error. Note that RequireComponent (see before class definition) already enforces this.
            if (!rigidBody)
            {
                Debug.LogError("The object " + gameObject.name + "requires a Rigidbody2D Component to work properly");
            }
        }

        // 2. set the rigidbody's velocity
        // Hint: set Rigidbody2D.velocity https://docs.unity3d.com/ScriptReference/Rigidbody-velocity.html

    }

    // This is called every frame
    void Update()
    {
        LimitSpeed();
        AdjustAngle();
    }

    // Optional exercice: Make sure the speed does not exceed max speed
    void LimitSpeed()
    {
        // 1. check if velocity's magnitude is greater than maximum speed

            // adjust velocity if needed
    }

    // Optional exercice: Make sure the angle of the ball's movement is higher than the minimum angle
    void AdjustAngle()
    {
        // 1. Is ball moving up or down?
 
        // 2. Is ball moving right or left?
        
        // 3. Choose Vector2.Right or -Vector2.Right depending on ball right / left direction
        
        // 4. Get the angle between horizontal direction and the ball's direction
        
        // 5. Adjust velocity's angle if < minimumAngle
            // store the velocity's magnitude
            // get target X and Y for new velocity
            // set velocity

    }

}
