using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour {
	//Player's destiny
	public string destiny = "";
	//Player's score
	public float score = 0f;
	public Text scoretext;
	public float richest = 4000.0f;
	public float rich = 1000;
	public float average = 500f;
	public float poor = 100f;
	public float poorest = 10f;
	//Did game begin?
	public bool gamebegin = false;
	public GameObject gamebeginMenu;
	public Text gamebeginText;
	public float gamebeginTimer = 2f;
	public float gamebeginCounter =0f;
	//Is game over?
	public bool isGameOver = false;

	//Entrance (doors and doorwalls)
	public GameObject Entrance;
	public float EntranceGoneSpeed = 2f;
	//procedual generation
	public GameObject FirstTrigger;
	public GameObject FirstObstacleTrigger;
	public GameObject ObstacleTrigger;
	public GameObject obstacle1;
	public GameObject[] wall;

	//Animation_obstacles
	public bool ObstacleRising;
	public float undergroundH = -4.4f;
	public float height = 5f;
	//obstacle index
	public int index1, index2, index3;
	public float ObstacleSize = 0.6f;

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
		//Player score
		//Debug.Log(score);
		scoretext.text = score.ToString();

		if(gamebegin){
			//display "game begins now" text
			gamebeginMenu.SetActive (true);
			gamebeginText.gameObject.SetActive (true);
			gamebeginCounter += Time.deltaTime;
			if (gamebeginCounter > gamebeginTimer) {
				gamebeginText.gameObject.SetActive (false);
			}
				
			//entrance doors dissapear
			if(Entrance.transform.position.y > -280f)
				Entrance.transform.Translate (Vector3.down * EntranceGoneSpeed * Time.deltaTime, Space.World);

			//generate first trigger
			if(FirstTrigger)
				FirstTrigger.gameObject.SetActive(true);

			if(FirstObstacleTrigger)
				FirstObstacleTrigger.gameObject.SetActive (true);
		}


		//Generate first trigger

		
	}


}
