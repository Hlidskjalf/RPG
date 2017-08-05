using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    float isGroundedRayLength = 0.1f;
    public LayerMask layerMaskForGrounded;
    public float speed;
    public float jumpSpeed;
    public float maxSpeed;
    public bool isGrounded
    {
        get
        {
            Vector3 position = transform.position;
            position.y = GetComponent<Collider2D>().bounds.min.y + 0.1f;
            float length = isGroundedRayLength + 0.1f;
            Debug.DrawRay(position, Vector3.down * length);
            bool grounded = Physics2D.Raycast(position, Vector3.down, length, layerMaskForGrounded.value);
            return grounded;
        }
    }
    Rigidbody2D rb;
    Vector3 jump = new Vector3(0.0f, 2.0f, 0.0f);

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector3(moveHorizontal, 0) * speed, ForceMode2D.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            rb.AddForce(jump * jumpSpeed, ForceMode2D.Impulse);
        }
        if (Mathf.Abs(rb.velocity.x) >= maxSpeed) {
            rb.AddForce(new Vector3(moveHorizontal, 0) * -(Mathf.Abs(rb.velocity.x) - maxSpeed), ForceMode2D.Impulse);
        }
       
    }
}
