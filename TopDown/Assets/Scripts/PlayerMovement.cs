using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public Transform target;
	Rigidbody2D rigid;
	float dx;
	float dy;
	float playerSpeedX = 500;
	float playerSpeedY = 500;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame

	void Update () {
		
		
		float dx = Input.GetAxis ("Horizontal");
		float dy = Input.GetAxis ("Vertical");

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (dx * playerSpeedX, dy * playerSpeedY) * Time.deltaTime;


	}
}
