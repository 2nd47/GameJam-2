using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		Vector3 bounceDir = Vector3.Reflect (other.transform.position, this.transform.position);
	}
}
