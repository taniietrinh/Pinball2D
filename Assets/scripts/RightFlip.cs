using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlip : MonoBehaviour {

	HingeJoint2D hinge;
	JointMotor2D jointMotor;

	// Use this for initialization
	void Start () {
		hinge = gameObject.GetComponent<HingeJoint2D> ();
		jointMotor = hinge.motor;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightShift)) {
			jointMotor.motorSpeed = -500;
		}
		hinge.motor = jointMotor;
	}
}
