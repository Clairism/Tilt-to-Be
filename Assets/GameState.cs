﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Restart(){
		//Application.LoadLevel (Application.loadedLevel);
		SceneManager.LoadScene ("Main"); 
	}
}
