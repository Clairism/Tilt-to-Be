using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (ObjectManager.s.destiny != "") {
			//Debug.Log ("Player has a destiny!");
			ObjectManager.s.gamebegin = true;
			if (ObjectManager.s.destiny == "richest") {
				ObjectManager.s.score = ObjectManager.s.richest;
			}
			if (ObjectManager.s.destiny == "rich") {
				ObjectManager.s.score = ObjectManager.s.rich;
			}
			if (ObjectManager.s.destiny == "average") {
				ObjectManager.s.score = ObjectManager.s.average;
			}
			if (ObjectManager.s.destiny == "poor") {
				ObjectManager.s.score = ObjectManager.s.poor;
			}
			if (ObjectManager.s.destiny == "poorest") {
				ObjectManager.s.score = ObjectManager.s.poorest;
			}
		}
	}
}
