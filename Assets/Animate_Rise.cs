using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate_Rise : MonoBehaviour {
	public float RiseV = 3f;
	private float newH = 8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Blue wall obstacles
		if (ObjectManager.s.gamebegin) {
			if (ObjectManager.s.ObstacleRising) {

			}
		}
	}
}
