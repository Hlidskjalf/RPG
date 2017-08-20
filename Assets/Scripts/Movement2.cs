using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CNControls;

public class Movement2 : MonoBehaviour {

    public float speed;
    public float maxSpeed;
    Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = CnControls.GetAxis("Horizontal");
        float moveVertical = CnControls.GetAxis("Vertical");


        rb.velocity = new Vector3(moveHorizontal, moveVertical) * speed;

        if (rb.velocity.magnitude > maxSpeed) {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        if (Input.GetKeyDown("return")) {
            RoomManager.ChangeRoom("Level 2");
            Debug.Log("Changed room!");
        }



    }
}
