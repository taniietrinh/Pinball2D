using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	private int count;
	public Text countText;

	// Use this for initialization
	void Start () {
		count = 0;
		SetCountText ();
	}

	void onTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("stars")) {
			count += 5;
			SetCountText ();
		}
		if (other.gameObject.CompareTag ("smallerStars")) {
			count += 10;
			SetCountText ();
		}

	}

	void SetCountText() {
		countText.text = "Score: " + count.ToString ();
	}
}
