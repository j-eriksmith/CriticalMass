using UnityEngine;
using System.Collections;

public class MeteorScript : MonoBehaviour {
    Rigidbody2D rigid;
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
        rigid.angularVelocity = Random.Range(-300, 300);
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, new Vector3(0, 0, 0)) > 30)
            Destroy(this.gameObject);
	}

   void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("verticle edge") 
            || coll.gameObject.CompareTag("Player") 
            || coll.gameObject.tag == "Planet"
            || coll.gameObject.tag == "Projectile")
        {
            ParticleSystem explosion = this.GetComponent<ParticleSystem>();
            this.GetComponent<Rigidbody2D>().isKinematic = true;
            this.GetComponent<CircleCollider2D>().enabled = false;
            explosion.Play();
            Destroy(this.gameObject, explosion.duration);
        }
    }
}
