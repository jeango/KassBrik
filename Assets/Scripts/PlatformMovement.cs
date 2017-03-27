using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    // The movement speed of the platform
    public float speed;
    // minimum X coordinate of the platform
    public float minX;
    // maximum X coordinate of the platform
    public float maxX;

    // Update is called once per frame
    // Note: we use FixedUpdate instead because we want more precise collisions. FixedUpdate is called at each Physical update (which can be several times per frame)
    void FixedUpdate()
    {
        // Call Move every frame
        Move();
    }

    // LateUpdate is called after all updates, before the scene is rendered
    void LateUpdate()
    {
        // Here we adjust the position so that the X coordinate of the platform is between minX and maxX

        // 1. store the current position of the platform in a new Vector3 called "newPos"

        // 2. clamp the value of newPos.x between minX and maxX (hint: use Mathf.Clamp() )

        // 3. update the position of the platform with the value of newPos

    }

    // Implement the platform movement here
    void Move()
    {
        // 1. Get Input from keyboard
        // Hint: https://docs.unity3d.com/ScriptReference/Input.GetAxis.html

        // 2. Multiply the result by speed

        // 3. Move the platform
        // Hint: https://docs.unity3d.com/ScriptReference/Transform.Translate.html
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
