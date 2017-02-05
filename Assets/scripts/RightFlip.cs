using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlip : MonoBehaviour {

	HingeJoint2D hinge;
	JointMotor2D jointMotor;
	Rigidbody2D rigidBody;
	Vector2 initialPos;
	Vector2 currentPos;

	// Use this for initialization
	void Start () {
		hinge = gameObject.GetComponent<HingeJoint2D> ();
		jointMotor = hinge.motor;
		rigidBody = hinge.connectedBody;
		initialPos = hinge.connectedBody.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightShift)) {
			jointMotor.motorSpeed = -500;
		} else {
			jointMotor.motorSpeed = 500;
		}
		hinge.motor = jointMotor;
	}
}
