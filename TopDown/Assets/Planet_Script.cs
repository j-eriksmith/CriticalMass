using UnityEngine;
using System.Collections;

public class Planet_Script : MonoBehaviour {

    public float growthFactor;
    float size = .3f;


	// Use this for initialization
	void Start () {

	    
	}
	
	// Update is called once per frame
	void Update () {
        if (size > this.transform.localScale.x)
        {
            transform.localScale += new Vector3(.1f, .1f, 0) * growthFactor;
        }

        if (this.transform.localScale.x >= .8f)
        {
            this.transform.localScale = new Vector3(.3f, .3f, 0);
            size = .3f;
        }
            

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            size += .1f;
        }
    }
}
