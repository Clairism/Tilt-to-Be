using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour {
	//Procedual Generation
	public float TriggerDistance = 210f;
	public GameObject Trigger;
	public GameObject Plane;

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
		}
	}
}
