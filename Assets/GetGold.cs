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
		if (other.gameObject.tag == "OneGold") {
			other.gameObject.SetActive (false);
			ObjectManager.s.score ++;
//			ObjectManager.s.scoretext.text = ObjectManager.s.score.ToString ();
		}
	}
}
