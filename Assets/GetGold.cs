using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGold : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		Debug.Log ("Collision Happens!");
		if (other.gameObject.name == "OneGold") {
			Debug.Log ("Getting One GOld!");
		}
	}
}
