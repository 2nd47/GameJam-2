using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownMovement : MonoBehaviour {

	Transform player;               // Reference to the player's position.

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;

	}

	void Update ()
	{
		var moveSpeed = 3;
		var rotationSpeed = 3;
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (player.position - transform.position), rotationSpeed * Time.deltaTime);
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
	}
}