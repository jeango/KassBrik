using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	// The score at the start of a new game
	public int initialScore =0;
	// The current score
	public int currentScore;
	// Reference to the score UI
	public Text scoreUI;


	void Start() {
		// set current score to initialscore
		// update the score UI
	}

	public void GainPoints(int value) {
		// add value to current score
		// update the score UI
	}

}
