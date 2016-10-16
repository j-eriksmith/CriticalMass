using UnityEngine;
using System.Collections;

public class ProjectileTest : MonoBehaviour {

    Rigidbody2D rigid;
	public AudioSource audioSource;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
		audioSource = GetComponent<AudioSource> ();
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player") 
            || collision.gameObject.CompareTag("Planet") 
            || collision.gameObject.tag == "meteor")
        {
            Destroy(this.gameObject);
			//audioSource.Play ();

        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("hit");
        if (coll.gameObject.CompareTag("horizontal edge"))
            rigid.velocity = new Vector2(rigid.velocity.x, rigid.velocity.y * -1);
        else if (coll.gameObject.CompareTag("verticle edge"))
            rigid.velocity = new Vector2(rigid.velocity.x * -1, rigid.velocity.y);
    }
}
