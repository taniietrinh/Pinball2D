using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlip : MonoBehaviour {
	Vector2 initialPos;

	// Use this for initialization
	void Start () {
		initialPos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			gameObject.transform.Rotate (0, 0, 40);
		}
		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			gameObject.transform.position = initialPos;
		}
	}
}
