using UnityEngine;
using System.Collections;

public class Obstacle_Script : MonoBehaviour {

    Vector3 center = new Vector3 (0,0,0);
    float radius = 1;
    Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(1, 0);
    }
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(transform.position, center);
        Vector3 move = Vector3.MoveTowards(transform.position, center, dist - radius);
        transform.position = move;

        //transform.LookAt(planet.transform, Vector3.right);

        Quaternion rotation = Quaternion.LookRotation(center - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
    }
}
