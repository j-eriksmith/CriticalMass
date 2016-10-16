using UnityEngine;
using System.Collections;

public class Planet_Script : MonoBehaviour {

    public float growthFactor;
    float size = .3f;
    public string playerNumber;

    GameObject cameraObject;


    // Use this for initialization
    void Start () {


        cameraObject = GameObject.Find("Main Camera");
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

            cameraObject.GetComponent<GameController>().GameOver(playerNumber);
        }
            

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile") || collision.gameObject.CompareTag("meteor"))
        {
            this.GetComponent<AudioSource>().Play();
            size += .1f;
        }
    }
}
