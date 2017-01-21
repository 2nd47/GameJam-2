using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			GetComponent<Animator>().SetTrigger("Walk");
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			GetComponent<Animator>().SetTrigger("Walk");
		} else if (Input.GetKey(KeyCode.LeftArrow)) {
			GetComponent<Animator>().SetTrigger("Walk");
			Vector3.Lerp(transform.position, transform.position += new Vector3(-2,0,0),  1.0f);
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			GetComponent<Animator>().SetTrigger("Walk");
			transform.position += new Vector3(2,0,0);
		}
	}
}
