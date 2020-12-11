using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbWizard : MonoBehaviour {
	int max;
	int min;
	int guess;


	// Use this for initialization
	void Start () {
		

	}
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;

		Debug.Log ("hi I am wizard");
		Debug.Log ("think a number between " + min + " and " + max);
		max = max + 1;
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			Debug.Log ("lower than");
			max = guess;
			Debug.Log (min);
			NextGuess ();

			Debug.Log (guess);

			}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			Debug.Log ("higher than");
			min = guess;
			Debug.Log (max);
			NextGuess ();
			Debug.Log (guess);
		}
		if(Input.GetKeyDown(KeyCode.Return)){
			Debug.Log ("enter was pressed");
		}
	}
	void NextGuess (){
		guess = (min + max) / 2;
		Debug.Log ("is it " + guess + " or higher(up) or lower(down)");
	
	}
}
