using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour {
	public float destroyTime = 30f;
	private float currentTime;
	public float distance;
	public GameObject objectToDestroy;


	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (currentTime > destroyTime) {
			currentTime = 0;
			Destroy (objectToDestroy);
		}

	}




}
