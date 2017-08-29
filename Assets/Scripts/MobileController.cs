using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MobileController : MonoBehaviour 
{
	Rigidbody2D player;
	public float moveForce = 5;

	void Start () 
	{
		player = this.GetComponent<Rigidbody2D> ();
	}
	
	void FixedUpdate () 
	{
		Vector2 moveVec = new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;

		player.AddForce (moveVec);
	}
}
