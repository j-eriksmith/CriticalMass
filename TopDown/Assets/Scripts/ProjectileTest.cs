using UnityEngine;
using System.Collections;

public class ProjectileTest : MonoBehaviour {

    Rigidbody2D rigid;
	public AudioSource audioSource;

	GameObject blackhole;
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
		audioSource = GetComponent<AudioSource> ();
		blackhole = GameObject.FindGameObjectWithTag("blackhole");

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
            ParticleSystem explosion = this.GetComponent<ParticleSystem>();
            this.GetComponent<Rigidbody2D>().isKinematic = true;
            this.GetComponent<CircleCollider2D>().enabled = false;
            explosion.Play();
            Destroy(this.gameObject, explosion.duration);
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


	public float maxGravDist = 2.6f;
	public float maxGravity = 162.0f;

	//GameObject[] blackhole;



	void FixedUpdate () {
		float dist = Vector3.Distance(blackhole.transform.position, transform.position);
		if (dist <= maxGravDist) {
			Vector3 v = blackhole.transform.position - transform.position;
			rigid.AddForce (v.normalized * (1.0f - dist / maxGravDist) * maxGravity);
		}
		}
	}
