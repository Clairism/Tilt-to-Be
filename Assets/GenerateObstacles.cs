using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour {
	public float Vdistance = 46f;
	public float Hdistance = 78f;

//	public int index1, index2;
	//public bool ObstacleRising;


	private static GenerateObstacles singleton;
	public static GenerateObstacles s { get { return singleton; } }

	protected void Awake(){
		singleton = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "CameraWall") {
			ObjectManager.s.ObstacleRising = true;
			//Instantiate obstacles
			//Vector3 ObstaclePos = new Vector3 (transform.position.x, transform.position.y, transform.position.z + Vdistance/2);
			//Instantiate (ObjectManager.s.obstacle1, ObstaclePos, Quaternion.identity);


			float debug = 15f;
			ObjectManager.s.index1 = Random.Range (0, 4);
			ObjectManager.s.index2 = Random.Range (0, 4);
			Vector3 wallPos1 = new Vector3 (Random.Range(transform.position.x - Hdistance/2, transform.position.x + Hdistance/2), ObjectManager.s.height, Random.Range(transform.position.z - Vdistance/2, transform.transform.position.z + Vdistance/2));
			Vector3 wallPos2 = new Vector3 (Random.Range(transform.position.x - Hdistance/2, transform.position.x + Hdistance/2), ObjectManager.s.height, Random.Range(transform.position.z - Vdistance/2, transform.transform.position.z + Vdistance/2));
			if (wallPos2.x < wallPos1.x + debug && wallPos2.x > wallPos1.x - debug) {
				if (wallPos2.z < wallPos1.z + debug && wallPos2.z > wallPos1.z - debug) {
					wallPos2 = new Vector3 (Random.Range(transform.position.x - Hdistance/2, transform.position.x + Hdistance/2), ObjectManager.s.height, Random.Range(transform.position.z - Vdistance/2, transform.transform.position.z + Vdistance/2));
				}
			}

			Instantiate (ObjectManager.s.wall[ObjectManager.s.index1], wallPos1, Quaternion.Euler(90f, 0f, 0f));
			Instantiate (ObjectManager.s.wall[ObjectManager.s.index2], wallPos2, Quaternion.Euler(90f, 0f, 0f));
			//Instantiate(ObjectManager.s.wall[2], wallPos1, Quaternion.Euler(90f,0f,0f));



			//Instantiate (ObjectManager.s.wall1, new Vector3(transform.position.x - Hdistance/2, transform.position.y, transform.position.z + Vdistance/2), Quaternion.Euler(90f,0f,0f));
			//Instantiate (ObjectManager.s.wall1, new Vector3(transform.position.x + Hdistance/2, transform.position.y, transform.position.z - Vdistance/2), Quaternion.Euler(90f,0f,0f));

			//Instantiate trigger
			Vector3 TriggerPos = new Vector3 (transform.position.x, transform.position.y, transform.position.z + Vdistance);
			Instantiate (ObjectManager.s.ObstacleTrigger, TriggerPos, Quaternion.identity);

			Destroy (gameObject);
		}
	}
}
