using UnityEngine;
using System.Collections;

public class Planet_Script : MonoBehaviour {

    public float growthFactor;
    float size = .3f;
    float greenHue = 1;
    public string playerNumber;
    public float hueGrowthFactor;

    GameObject cameraObject;
    SpriteRenderer sprite;


    // Use this for initialization
    void Start () {

        sprite = this.GetComponent<SpriteRenderer>();
        cameraObject = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
        if (size > this.transform.localScale.x)
        {
            transform.localScale += new Vector3(.1f, .1f, 0) * growthFactor;
        }
        if (greenHue < sprite.color.g)
        {
            float greenVal = sprite.color.g;
            sprite.color = new Color(1, greenVal - hueGrowthFactor, 1);
        }

        if (this.transform.localScale.x > .8f)
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
            greenHue -= .2f;
        }
    }
}
