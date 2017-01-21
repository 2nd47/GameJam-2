using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public float damping = 1;

	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		float desiredAngle = player.transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
		Vector3 desiredPosition = player.transform.position + (rotation * offset);
		transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping * 2);
		transform.LookAt (player.transform.position);
	}
}
