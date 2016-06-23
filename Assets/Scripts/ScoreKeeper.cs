using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void IncrementScore(int amount) {
		score += amount;
		print ("You scored. Your current score is " + score);
	}
}
