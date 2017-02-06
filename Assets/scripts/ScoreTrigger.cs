using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrigger : MonoBehaviour {

	private int score;
	public Text countText;

	// Use this for initialization
	void Start () {
		score = 0;
		setCountText ();
	}

	void onTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("stars")) {
			score = score + 5;
			setCountText ();
		}
		if (other.gameObject.CompareTag ("smallerStars")) {
			score = score + 10;
			setCountText ();
		}

	}

	// Update is called once per frame
	void Update () {
		/*
		if (ball.IsTouching (collider) == true) {
			score++;
		}
		*/
	}

	void setCountText() {
		countText.text = "Score: " + score.ToString ();
	}

}
