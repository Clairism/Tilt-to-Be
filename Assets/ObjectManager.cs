using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour {
	//Player's destiny
	public string destiny = "";



	private static ObjectManager singleton;
	public static ObjectManager s { get { return singleton; } }

	protected void Awake(){
		singleton = this;
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
