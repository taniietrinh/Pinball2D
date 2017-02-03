using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightShift)) {
			gameObject.transform.Rotate(0,0,-40);

		}
	}
}
