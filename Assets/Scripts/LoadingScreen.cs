using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour {

	public GameObject player;

	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
	}

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D collider) 
     {
     if(collider.tag == "Player")
     Application.LoadLevel("Loading");
     }
}
