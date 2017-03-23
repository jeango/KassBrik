using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerSol : MonoBehaviour {

	// The score at the start of a new game
	public int initialScore =0;
	// The current score
	public int currentScore;
	// Reference to the score UI
	public Text scoreUI;


	void Start() {
		// set current score to initialscore
		currentScore = initialScore;
		// update the score UI
		scoreUI.text = "" + currentScore; // necessary to make sure a string is passed and not an int
	}

	public void GainPoints(int value) {
		// add value to current score
		currentScore += value;
		// update the score UI
		scoreUI.text = "" + currentScore;
	}
}
