using UnityEngine;
using System.Collections;

public class Planet_Script : MonoBehaviour {


	// Use this for initialization
	void Start () {

	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (this.transform.localScale.x >= .8f)
            this.transform.localScale -= new Vector3(.5f, .5f, 0);

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            this.transform.localScale += new Vector3(.1f, .1f, 0);
        }
    }
}
