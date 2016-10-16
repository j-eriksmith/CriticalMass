using UnityEngine;
using System.Collections;

public class OrbitScript : MonoBehaviour {

    public Vector2 orbitCenter;
    Vector2 radialVector;
    Rigidbody2D rigid;
    float correctiveForce, cForce;
    float angle, vTangental, fCentripetal, radius, targetRadius, radDiff;
    float P = .5F, I = 1, D = 1;
    float Pv, Iv, Dv = 0;
    public float initialVelocity;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector3.right * initialVelocity;
        targetRadius = Vector2.Distance(transform.position, orbitCenter);
	}
	
	// Update is called once per frame
	void Update () {
        radialVector = orbitCenter - new Vector2(transform.position.x, transform.position.y);
        angle = Vector2.Angle(rigid.velocity, radialVector);
        vTangental = Mathf.Sin(angle * Mathf.Deg2Rad) * rigid.velocity.magnitude;
        correctiveForce = 10 + 10 * Mathf.Pow(vTangental, 2);
        radius = Vector2.Distance(transform.position, orbitCenter);
        radDiff = (radius - targetRadius);
        Pv = radDiff;
        Iv = -Mathf.Cos(Mathf.Deg2Rad * angle);
        Dv = (Dv * 9 + 100 * radDiff * Time.deltaTime) / 10;
        fCentripetal = (rigid.mass * Mathf.Pow(vTangental, 2)) / radius;
        cForce = (P * Pv + I * Iv + D * Dv) * correctiveForce;
        fCentripetal += cForce;
        rigid.AddForce(Vector3.Normalize(new Vector3(radialVector.x, radialVector.y, 0)) * fCentripetal);
	}
}
