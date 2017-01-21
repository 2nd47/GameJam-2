using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownMovement : MonoBehaviour {



	Transform player;               // Reference to the player's position.
	UnityEngine.AI.NavMeshAgent nav;               // Reference to the nav mesh agent.

	void Awake ()
	{
		// Set up the references.
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
	}

	void Update ()
	{
	}
}
