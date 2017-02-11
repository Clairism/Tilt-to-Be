using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLife : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {
		Debug.Log ("ENTEREED");
		if (other.gameObject.name == "richest") {
			//Debug.Log ("richest");
		}

		if (other.gameObject.name == "rich") {
		}

		if (other.gameObject.name == "ok") {
		}

		if (other.gameObject.name == "poor") {
		}

		if (other.gameObject.name == "poorest") {
		}
	
	}

	void OnTriggerEnter(Collider other){
		//Debug.Log ("enter!");
		if (other.gameObject.name == "player") {
			//Debug.Log ("player enter");
			ObjectManager.s.destiny = gameObject.name.ToString ();
			Debug.Log (ObjectManager.s.destiny);
		}

	}
}
