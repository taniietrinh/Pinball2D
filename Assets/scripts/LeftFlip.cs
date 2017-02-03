using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlip : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			gameObject.transform.Rotate(0,0,40);

		}

	}
}
