using UnityEngine;
using System.Collections;

public class Blackhole : MonoBehaviour
{
    Rigidbody2D rb;
    public float spinRate;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.angularVelocity = spinRate;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            Destroy(other.gameObject);
            this.GetComponent<AudioSource>().Play();
            this.GetComponent<ParticleSystem>().Play();
        }
    }
}
