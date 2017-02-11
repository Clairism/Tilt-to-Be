using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public float speed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * speed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.back * speed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime, Space.World);
		}
	}
}
