using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour {

	int score;
	Collider2D ball;
	Collider2D collider;
	// Use this for initialization
	void Start () {
		score = 0;
		ball = gameObject.GetComponent<Collider2D> ();
		collider = gameObject.GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ball.IsTouching (collider) == true) {
			score++;
		}
		print ("score: " + score);
	}
}
