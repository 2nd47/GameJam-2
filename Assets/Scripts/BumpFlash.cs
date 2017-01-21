using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpFlash : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Flash the collider if something bumps it
	void OnTriggerEnter (Collider other) {
		this.gameObject.GetComponent<Renderer> ().material.color = Color.red;
	}
}
