using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform target; //This will be your citizen
    public float distance;


    void Update() {
        if (!target) {
            // Search for object with Player tag
            var go = GameObject.FindWithTag("Player");
            // Check we found an object with the player tag
            if (go)
                // Set the target to the object we found
                target = go.transform;
        }

        if (target)
            transform.position = new Vector3(target.position.x, target.position.y, target.position.z - distance);
    }
}
