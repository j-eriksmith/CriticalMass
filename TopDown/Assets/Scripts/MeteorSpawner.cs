using UnityEngine;
using System.Collections;

public class MeteorSpawner : MonoBehaviour {

	public GameObject[] spawners;
	public float waveDelay = 1f;

	private static int initialCountToShower = 100;
	private static int countToShower = initialCountToShower;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		countToShower--;
		checkForShower ();
	}

	void checkForShower(){
		if (countToShower == 0) {
			StartCoroutine(startShower ());
			countToShower = initialCountToShower;
		}
		print (countToShower);
	}

	IEnumerator startShower(){
		int chosenSpawner = Random.Range (0, 4);
		if (chosenSpawner == 0 || chosenSpawner == 1) {
			spawners [chosenSpawner].GetComponent<Shower> ().meteorShower (0, chosenSpawner);
			yield return new WaitForSeconds (waveDelay);
			spawners [chosenSpawner].GetComponent<Shower> ().meteorShower (0, chosenSpawner);
			yield return new WaitForSeconds (waveDelay);
			spawners [chosenSpawner].GetComponent<Shower> ().meteorShower (0, chosenSpawner);
		}
		if (chosenSpawner == 2 || chosenSpawner == 3) {
			spawners [chosenSpawner].GetComponent<Shower> ().meteorShower (1, chosenSpawner);
			yield return new WaitForSeconds (waveDelay);
			spawners [chosenSpawner].GetComponent<Shower> ().meteorShower (1, chosenSpawner);
			yield return new WaitForSeconds (waveDelay);
			spawners [chosenSpawner].GetComponent<Shower> ().meteorShower (1, chosenSpawner);
		}
	}
}