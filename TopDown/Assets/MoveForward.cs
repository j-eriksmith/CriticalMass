using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	Rigidbody2D rb;

	float speed = 10;

	
	// Update is called once per frame
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		transform.position += transform.up * speed * Time.deltaTime;
	
	}
}
