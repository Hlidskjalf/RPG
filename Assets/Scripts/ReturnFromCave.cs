using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFromCave : MonoBehaviour {

	public GameObject player;

	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
	}

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other) {
		player.transform.position = new Vector2(3646, -123);
	}
}