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

	Vector3 circleCenter;
	float radius;
    public GameObject planet;

	// Use this for initialization
	void Start () {

		rigid = GetComponent<Rigidbody2D> ();
        planet = GameObject.FindWithTag("Planet1");
        circleCenter = new Vector3(-10, 0, 0);
        radius = 3;
    }
	
	// Update is called once per frame

	void Update () {
		



		float leftDx = Input.GetAxis ("Horizontal");
		float leftDy = Input.GetAxis ("Vertical");

        //float leftDx = Input.GetAxis ("LeftJoystickX");
        //float leftDy = Input.GetAxis("LeftJoystickX");

        //rigid.velocity = new Vector2 (leftDx * playerSpeedX, leftDy * playerSpeedY) * Time.deltaTime;

        //vec = new Vector3(leftDx, leftDy, 0);
        float x, y;
        x = -Mathf.Sin(Mathf.Deg2Rad * transform.rotation.eulerAngles.z);
        y = Mathf.Cos(Mathf.Deg2Rad * transform.rotation.eulerAngles.z);
        vec = new Vector3(x, y, 0);

        //if (Input.GetAxisRaw ("Horizontal") != 0)
			//rigid.AddForce (vec * thrust);
        
        if (this.name == "Player_1")
        {
            if (Input.GetKey("w"))
                rigid.AddForce(vec * thrust);
            else if (Input.GetKey("s"))
                rigid.AddForce(vec * -thrust);
        }
        else if (this.name == "Player_2")
        {
            if (Input.GetKey("down"))
                rigid.AddForce(vec * thrust);
            else if (Input.GetKey("up"))
                rigid.AddForce(vec * -thrust);
        }
		

        /*
        Vector3 test = new Vector3(0, 0, 0); 
        Vector3 offset = circleCenter - transform.position;
        test = transform.rotation.eulerAngles;
        Vector3.RotateTowards(test, offset, 1.0F, 0.0F);
        transform.rotation = Quaternion.Euler(offset);
        */

        float dist = Vector3.Distance(transform.position, planet.transform.position);
        Vector3 move = Vector3.MoveTowards(transform.position, planet.transform.position, dist - radius);
        transform.position = move;

        //transform.LookAt(planet.transform, Vector3.right);

        Quaternion rotation = Quaternion.LookRotation(planet.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
        //transform.Rotate(0, 0, 90);
        /*
        offset.Normalize ();
		offset = offset * 1;
		transform.position = offset; 
		*/
		
		

	}
}
