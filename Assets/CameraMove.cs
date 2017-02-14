using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	public float speed = 5f;
	public GameObject target;
	public float movetoSpeed = 20f;
	public Camera camera;

	float LerpTime = 1f;
	float CurrentLerpTime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (ObjectManager.s.gamebegin) {
			transform.Translate (Vector3.forward * speed * Time.deltaTime, Space.World);
			CurrentLerpTime = 0f;
		}

		if (ObjectManager.s.isGameOver) {
			//transform.position = Vector3.MoveTowards (transform.position, target.transform.position, movetoSpeed);
			camera.orthographic = false;
			CurrentLerpTime += Time.deltaTime;
			float x = CurrentLerpTime / LerpTime;
			transform.position = Vector3.Lerp (transform.position, target.transform.position, x);
		}
			
		
	}


}
