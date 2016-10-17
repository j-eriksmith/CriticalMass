using UnityEngine;
using System.Collections;

public class ExplodeScript : MonoBehaviour {

    public bool exploding = false;
    public float delay = 0, speed = 1;
    float elapsed = 0, size;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(exploding)
        {
            elapsed += Time.deltaTime;
            if(elapsed > delay)
            {
                size = Mathf.Pow((elapsed - delay) * speed, 2);
                if(size > 100)
                {
                    transform.localScale = new Vector3(100, 100);
                    exploding = false;
                }
                else
                {
                    transform.localScale = new Vector3(size, size);
                }
            }
        }
	}

    void Explode()
    {
        exploding = true;
    }
}
