using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour {
	//Procedual Generation
	public float TriggerDistance = 210f;
	public float Width = 80f;
	public GameObject Trigger;
	public GameObject Plane;
	public GameObject OneGold;//

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		if (ObjectManager.s.gamebegin) {
//			gameObject.SetActive (true);
//		}
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "CameraWall") {
			//Debug.Log(" player Instantiating");
			//if (ObjectManager.s.gamebegin) {
				//Instantiate next plane & obstacles
				//Debug.Log("Instantiating");
			float planeH = 1.5f;
			Vector3 TriggerPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + TriggerDistance);
			Vector3 PlanePos = new Vector3 (transform.position.x, planeH,transform.position.z + TriggerDistance);
			Instantiate(Trigger, TriggerPos, Quaternion.identity);
			Instantiate (Plane, PlanePos, Quaternion.identity);
			this.enabled = false;
			//}
//			Vector3 GoldPos1 = new Vector3(transform.position.x + Width/2, ObjectManager.s.height, transform.position.z + TriggerDistance * 2 );
//			Vector3 GoldPos2 = new Vector3 (transform.position.x - Width/2, ObjectManager.s.height, transform.position.z + TriggerDistance * 2);
//			Vector3 GoldPos3 = new Vector3 (transform.position.x + Width/2, ObjectManager.s.height, transform.position.z);
//			Vector3 GoldPos4 = new Vector3 (transform.position.x - Width/2, ObjectManager.s.height, transform.position.z);
//			Instantiate(OneGold, GoldPos1, Quaternion.identity);
//			Instantiate(OneGold, GoldPos2, Quaternion.identity);
//			Instantiate(OneGold, GoldPos3, Quaternion.identity);
//			Instantiate(OneGold, GoldPos4, Quaternion.identity);
			GenerateGold(20f);

		}
	}

	void GenerateGold(float x){
		for (int i = 0; i < x; i++) {
			Vector3 GoldPos = new Vector3 (Random.Range(transform.position.x - Width/2, transform.position.x + Width/2), ObjectManager.s.height, Random.Range(transform.position.z, transform.position.z + TriggerDistance * 2));
			Instantiate (OneGold, GoldPos, Quaternion.identity);
		}
	}
}
