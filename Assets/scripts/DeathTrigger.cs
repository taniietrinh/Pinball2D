using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		other.gameObject.transform.position = new Vector3(-2,2,0);
		}
}
