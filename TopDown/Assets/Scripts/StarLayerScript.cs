using UnityEngine;
using System.Collections;

public class StarLayerScript : MonoBehaviour {

    public float rotationRate;
    Color color;
    SpriteRenderer sprite;
    public float scaleAmount;

	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotationRate);
        sprite.color = GetComponentInParent<Planet_Script>().getColor() * scaleAmount + new Color(1,1,1) * (1 - scaleAmount);
	}
}
