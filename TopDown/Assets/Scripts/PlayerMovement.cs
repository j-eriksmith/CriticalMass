using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	Rigidbody2D rigid;
	public float thrust = 10;
	float leftDx;
	float leftDy;
	float playerSpeedX = 500;
	float playerSpeedY = 500;
	Vector3 vec;

	// Use this for initialization
	void Start () {

		rigid = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame

	void Update () {
		



		float leftDx = Input.GetAxis ("Horizontal");
		float leftDy = Input.GetAxis ("Vertical");

		//float leftDx = Input.GetAxis ("LeftJoystickX");
		//float leftDy = Input.GetAxis("LeftJoystickX");

		//rigid.velocity = new Vector2 (leftDx * playerSpeedX, leftDy * playerSpeedY) * Time.deltaTime;

		vec = new Vector3(leftDx, leftDy, 0);

		if (Input.GetAxisRaw ("Horizontal") != 0)
			rigid.AddForce (vec * thrust);

		if (Input.GetAxisRaw ("Vertical") != 0)
			rigid.AddForce (vec * thrust);
			
		
		

	}
}
