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
			Vector3.Lerp(transform.position, transform.position += new Vector3(0.0f, 0.0f, 0.1f), 5.0f);

			float moveHorizontal = Input.GetAxisRaw ("Horizontal");
			float moveVertical = Input.GetAxisRaw ("Vertical");
			Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
			transform.rotation = Quaternion.LookRotation(movement);
			transform.Translate (movement *  5.0f * Time.deltaTime, Space.World);
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			GetComponent<Animator>().SetTrigger("Walk");
			Vector3.Lerp(transform.position, transform.position += new Vector3(0.0f, 0.0f, -0.1f), 5.0f);

			float moveHorizontal = Input.GetAxisRaw ("Horizontal");
			float moveVertical = Input.GetAxisRaw ("Vertical");
			Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
			transform.rotation = Quaternion.LookRotation(movement);
			transform.Translate (movement *  5.0f * Time.deltaTime, Space.World);
		} else if (Input.GetKey(KeyCode.LeftArrow)) {
			GetComponent<Animator>().SetTrigger("Walk");
			Vector3.Lerp(transform.position, transform.position += new Vector3(-0.1f, 0.0f, 0.0f), 5.0f);

			float moveHorizontal = Input.GetAxisRaw ("Horizontal");
			float moveVertical = Input.GetAxisRaw ("Vertical");
			Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
			transform.rotation = Quaternion.LookRotation(movement);
			transform.Translate (movement *  5.0f * Time.deltaTime, Space.World);
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			GetComponent<Animator>().SetTrigger("Walk");
			Vector3.Lerp(transform.position, transform.position += new Vector3(0.1f, 0.0f, 0.0f), 5.0f);

			float moveHorizontal = Input.GetAxisRaw ("Horizontal");
			float moveVertical = Input.GetAxisRaw ("Vertical");
			Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
			transform.rotation = Quaternion.LookRotation(movement);
			transform.Translate (movement *  5.0f * Time.deltaTime, Space.World);
		}
	}
}
