﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlip : MonoBehaviour {

	HingeJoint2D hinge;
	JointMotor2D jointMotor;
	Rigidbody2D flipper;

	// Use this for initialization
	void Start () {
		hinge = gameObject.GetComponent<HingeJoint2D> ();
		flipper = hinge.connectedBody;
		jointMotor = hinge.motor;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftShift)) {
			jointMotor.motorSpeed = 500;
		}
		hinge.motor = jointMotor;
	}
}
