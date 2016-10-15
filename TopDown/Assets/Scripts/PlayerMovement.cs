using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public Transform target;
	Rigidbody2D rigid;
	float leftDx;
	float leftDy;
	float playerSpeedX = 500;
	float playerSpeedY = 500;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame

	void Update () {
		



		float leftDx = Input.GetAxis ("LeftJoystickX");
		float leftDy = Input.GetAxis ("LeftJoystickY");

		//float leftDx = Input.GetAxis ("Horizontal");
		//float leftDy = Input.GetAxis("Vertical");

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (leftDx * playerSpeedX, leftDy * playerSpeedY) * Time.deltaTime;

		

	}
}
