using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	public float speed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime, Space.World);
	}
}
