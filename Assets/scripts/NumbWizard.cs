using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumbWizard : MonoBehaviour {
    [SerializeField]  int max=1000;
    [SerializeField]  int min=1;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;


	// Use this for initialization
	void Start () {
        StartGame();

    }
	void StartGame () {

        NextGuess();
        
    }
    public void OnpressHigher() {
        min = guess;
        NextGuess();
        min = min + 1;
        
    }
    public void Onpresslower()
    {
        max = guess;
        NextGuess();
        max = max - 1;
    }
    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess ();
            }
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			NextGuess ();
			
		}
		if(Input.GetKeyDown(KeyCode.Return)){
            StartGame();

        }
	}
	void NextGuess (){
		guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
        
    }
}
