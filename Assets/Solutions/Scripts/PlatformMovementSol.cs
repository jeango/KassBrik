using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlatformMovementSol : MonoBehaviour {

	// The movement speed of the platform
	public float speed;
    // a reference to the rigidbody of the platform
	public Rigidbody2D rigidBody;
    // minimum X coordinate of the platform
    public float minX;
    // maximum X coordinate of the platform
    public float maxX;

    // Used for initialization
    void Start()
    {
        // 1. check if rigidbody is initialized
        // 2. If not then get the rigidbody component attached to the game object
        if (!rigidBody) rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    // Note: we use FixedUpdate instead because we want more precise collisions. FixedUpdate is called at each Physical update (which can be several times per frame)
	void FixedUpdate () {
		// Call Move every frame
		Move();
	}

    // LateUpdate is called after all updates, before the scene is rendered
    void LateUpdate()
    {
        // Here we adjust the position so that the X coordinate of the platform is between minX and maxX

        // 1. store the current position of the platform in a new Vector3 called "newPos"
        Vector3 newPos = transform.position;
        // 2. clamp the value of newPos.x between minX and maxX (hint: use Mathf.Clamp() )
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        // 3. update the position of the platform with the value of newPos
        transform.position = newPos;

    }

    // Implement the platform movement here
    void Move () {
		// 1. Get Input from keyboard
		// Hint: https://docs.unity3d.com/ScriptReference/Input.GetAxis.html
		float horizontalSpeed = Input.GetAxisRaw("Horizontal") * speed;   // We multiply the speed by the calculation time of the fixed update. This allows for smooth movement.

        // 2. Move the platform
        // Hint: https://docs.unity3d.com/ScriptReference/Transform.Translate.html
        // Note: we could also use RigidBody2D.velocity

        transform.Translate(Vector3.right * horizontalSpeed * Time.fixedDeltaTime);
	}

    // This draws a visual representation of minX and maxX in the editor
    // It won't be seen in the final game.
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(minX, -100.0f), new Vector3(minX, 100.0f));
        Gizmos.DrawLine(new Vector3(maxX, -100.0f), new Vector3(maxX, 100.0f));

    }

}
