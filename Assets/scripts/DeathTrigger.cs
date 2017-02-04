using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other) {
		other.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
		}
}
