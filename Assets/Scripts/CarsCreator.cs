using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsCreator : MonoBehaviour {

	public GameObject Carros;
	public float MinTimeToCreator = 1f;
	public float MaxTimeToCreator = 3f;
	private float timeToNextCreation;
	private float countTimer;
	private float xMin;
	private float xMax;

	void Start () {
		float horizontalExtension = Camera.main.orthographicSize * Screen.width / Screen.height;
		xMin = -horizontalExtension * 0.65f;
		xMax = horizontalExtension * 0.65f;

	}
	
	// Update is called once per frame
	void Update () {
		countTimer += Time.deltaTime;
		if (countTimer >= timeToNextCreation) {
			countTimer = 0;
			GenerationNextTime ();

			Vector3 pos = transform.position;
			pos.x = Random.Range (xMin, xMax);
			GameObject.Instantiate (Carros, pos, Quaternion.identity);
		}
	}

	void GenerationNextTime(){
		timeToNextCreation = Random.Range (MinTimeToCreator, MaxTimeToCreator);

	}


}
