using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
	[SerializeField] Text textComponent;
	[SerializeField] State startingState;
	[SerializeField] State[] movingState;


	State state;

	// Use this for initialization
	void Start () {
		state = startingState;
		textComponent.text = state.GetStateStory ();
	}
	
	// Update is called once per frame
	void Update () {
		ManageState();
	}

	private void ManageState(){
		var nextStates = state.GetNextState ();
        for (int index = 0; index<nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
                print("state "+index+" now!");
            }
            
        }
		textComponent.text = state.GetStateStory ();
	}
}
