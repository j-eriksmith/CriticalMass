using UnityEngine;
using System.Collections;

public class ProjectileTest : MonoBehaviour {

    Rigidbody2D rigid;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(2, 2);  //Test velocity

    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Horizontal Collider"))
            rigid.velocity = new Vector2(rigid.velocity.x, rigid.velocity.y * -1);
        if (collision.gameObject.CompareTag("Vertical Collider"))
            rigid.velocity = new Vector2(rigid.velocity.x * -1, rigid.velocity.y);
    }
}
