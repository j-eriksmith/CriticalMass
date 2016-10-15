using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	public GameObject cannonPrefab;

	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Fire1") && cooldownTimer <= 0) {
			Debug.Log ("Pew pew pew");
			cooldownTimer = fireDelay;

			Instantiate (cannonPrefab, transform.position, transform.rotation);
		
		}

	
	}
}
