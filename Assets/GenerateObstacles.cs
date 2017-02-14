using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour {
	public float Vdistance = 46f;
	public float Hdistance = 78f;
	//public float ObstacleSize = 0.7f;
	private Vector3 position;
	private float rotation = 0f;
//	public int index1, index2;
	//public bool ObstacleRising;


	private static GenerateObstacles singleton;
	public static GenerateObstacles s { get { return singleton; } }

	protected void Awake(){
		singleton = this;
	}

	// Use this for initialization
	void Start () {
		position = new Vector3 (0f,0f,0f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "CameraWall") {
			ObjectManager.s.ObstacleRising = true;


			//float debug = 20f;
			ObjectManager.s.index1 = Random.Range (0, 4);
			ObjectManager.s.index2 = Random.Range (0, 4);
			ObjectManager.s.index3 = Random.Range (0, 4);
//			Vector3 wallPos1 = new Vector3 (Random.Range(transform.position.x - Hdistance/2, transform.position.x + Hdistance/2), ObjectManager.s.height, Random.Range(transform.position.z, transform.transform.position.z + Vdistance));
//			Vector3 wallPos2 = new Vector3 (Random.Range(transform.position.x - Hdistance/2, transform.position.x + Hdistance/2), ObjectManager.s.height, Random.Range(transform.position.z, transform.transform.position.z + Vdistance));
//			if (wallPos2.x < wallPos1.x + debug && wallPos2.x > wallPos1.x - debug) {
//				if (wallPos2.z < wallPos1.z + debug && wallPos2.z > wallPos1.z - debug) {
//					wallPos2 = new Vector3 (Random.Range(transform.position.x - Hdistance/2, transform.position.x + Hdistance/2), ObjectManager.s.height, Random.Range(transform.position.z, transform.transform.position.z + Vdistance));
//				}
//			}


			//RandomPosition (Random.Range(0,1.9f));
			Instantiate (ObjectManager.s.wall[ObjectManager.s.index1], RandomPos(Random.Range(0f, 0.99f)), Quaternion.Euler(90f, 0f, RandomRotation(Random.Range(0f, 2f))));
			//RandomPosition (Random.Range(2,4));
			Instantiate (ObjectManager.s.wall[ObjectManager.s.index2], RandomPos(Random.Range(1.01f, 1.99f)), Quaternion.Euler(90f, 0f, RandomRotation(Random.Range(0f,2f))));
			Instantiate (ObjectManager.s.wall[ObjectManager.s.index3], RandomPos(Random.Range(2.01f, 4f)), Quaternion.Euler(90f, 0f, RandomRotation(Random.Range(0f,2f))));
			Debug.Log (RandomRotation(0.5f));
			Debug.Log (RandomRotation(1.5f));


			ObjectManager.s.wall [ObjectManager.s.index1].gameObject.transform.localScale = new Vector3 (ObjectManager.s.ObstacleSize, ObjectManager.s.ObstacleSize, ObjectManager.s.ObstacleSize);
			ObjectManager.s.wall [ObjectManager.s.index2].gameObject.transform.localScale = new Vector3 (ObjectManager.s.ObstacleSize, ObjectManager.s.ObstacleSize, ObjectManager.s.ObstacleSize);

			//Instantiate trigger
			Vector3 TriggerPos = new Vector3 (transform.position.x, transform.position.y, transform.position.z + Vdistance);
			Instantiate (ObjectManager.s.ObstacleTrigger, TriggerPos, Quaternion.identity);

			Destroy (gameObject);
		}
	}

	float RandomRotation(float randomR){
		if (randomR >= 0 && randomR <= 1) {
			rotation = 0f;
		} else if (randomR > 1 && randomR <= 2) {
			rotation = 90f;
		}
		return rotation;

	}

//	void RandomPosition(float f){
//		float range = 15f;
//		if (f > 0 && f <= 1) {
//			posX = transform.position.x - Hdistance / 4 + Random.Range (-range, range);
//			posY = transform.position.z + Vdistance / 4 + Random.Range (-range, range);
//			position = new Vector3 (transform.position.x - Hdistance/4 + Random.Range(-range, range), ObjectManager.s.height, transform.position.z + Vdistance/4 + Random.Range(-range, range));
//		} else if (f > 1 && f <= 2) {
//			posX = transform.position.x - Hdistance / 4 + Random.Range (-range, range);
//			posY = transform.position.z + 3 * Vdistance / 4 + Random.Range (-range, range);
//			position = new Vector3 (transform.position.x - Hdistance/4 + Random.Range(-range, range), ObjectManager.s.height, transform.position.z + 3 * Vdistance/4 + Random.Range(-range, range));
//		} else if (f > 2 && f <= 3) {
//			posX = transform.position.x + Hdistance / 4 + Random.Range (-range, range);
//			posY = transform.position.z + 3 * Vdistance / 4 + Random.Range (-range, range);
//			position = new Vector3 (transform.position.x + Hdistance/4 + Random.Range(-range, range), ObjectManager.s.height, transform.position.z + Vdistance/4 + Random.Range(-range, range));
//		} else if (f > 3 && f <= 4) {
//			posX = transform.position.x + Hdistance / 4 + Random.Range (-range, range);
//			posY = transform.position.z + Vdistance / 4 + Random.Range (-range, range);
//			position = new Vector3 (transform.position.x + Hdistance/4 + Random.Range(-range, range), ObjectManager.s.height, transform.position.z + 3 * Vdistance/4 + Random.Range(-range, range));
//		}
//		//return position;
//	}

	Vector3 RandomPos(float f){
		float range = 5f;
		if (f >= 0 && f <= 1) {
			//posX = transform.position.x - Hdistance / 4 + Random.Range (-range, range);
			//posY = transform.position.z + Vdistance / 4 + Random.Range (-range, range);
			position = new Vector3 (transform.position.x - Hdistance/4 + Random.Range(-range, range), ObjectManager.s.height, transform.position.z + Vdistance/4 + Random.Range(-range, range));
		} else if (f > 1 && f <= 2) {
			//posX = transform.position.x - Hdistance / 4 + Random.Range (-range, range);
			//posY = transform.position.z + 3 * Vdistance / 4 + Random.Range (-range, range);
			position = new Vector3 (transform.position.x - Hdistance/4 + Random.Range(-range, range), ObjectManager.s.height, transform.position.z + 3 * Vdistance/4 + Random.Range(-range, range));
		} else if (f > 2 && f <= 3) {
			//posX = transform.position.x + Hdistance / 4 + Random.Range (-range, range);
			//posY = transform.position.z + 3 * Vdistance / 4 + Random.Range (-range, range);
			position = new Vector3 (transform.position.x + Hdistance/4 + Random.Range(-range, range), ObjectManager.s.height, transform.position.z + Vdistance/4 + Random.Range(-range, range));
		} else if (f > 3 && f <= 4) {
			//posX = transform.position.x + Hdistance / 4 + Random.Range (-range, range);
			//posY = transform.position.z + Vdistance / 4 + Random.Range (-range, range);
			position = new Vector3 (transform.position.x + Hdistance/4 + Random.Range(-range, range), ObjectManager.s.height, transform.position.z + 3 * Vdistance/4 + Random.Range(-range, range));
		}
		return position;
	}
}
