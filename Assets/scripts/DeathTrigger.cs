using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {
	public Text endText;

	void Start() {
		endText.text = "";
	}
	void Update() {
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene ("Ball_Flippers");
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		//other.gameObject.transform.position = new Vector3(-2,2,0);
		SetEndText();
	}

	void SetEndText() {
		endText.text = "Press Space to Play Again";
	}

}
