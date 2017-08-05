using Logic.States;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour {

    public StateStack stateStack;

	// Use this for initialization
	void Start () {
        stateStack = GetComponent<StateStack>();

        //Add all possible states here
        stateStack.Add("Game", new GameState());

        //Push the first thingy on
        stateStack.Push("Game");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
