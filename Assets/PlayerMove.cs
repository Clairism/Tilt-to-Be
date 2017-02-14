using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {
	public float speed = 5f;
	public float speed_mobile = 2f;
	public Vector3 originalA;
//	public Text accX, accY, accZ;
	public Text gameOverText;
	public GameObject restartButton;
	// Use this for initialization

	bool gameOver = false;

	void Start () {
		originalA = new Vector3 (Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * speed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.back * speed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime, Space.World);
		}
		float debugY = 1f;
//		accX.text = Input.acceleration.x.ToString ();
//		accY.text = Input.acceleration.y.ToString ();
//		accZ.text = Input.acceleration.y.ToString ();
		if (Input.acceleration.y > 0) {
			debugY = 2f;
		}
		transform.Translate(Input.acceleration.x * 2 * speed_mobile, 0 , Input.acceleration.y * debugY * speed_mobile);


		if (gameOver) {
			gameOverText.gameObject.SetActive (true);
			restartButton.SetActive (true);
			//Destroy (this);
		}
	}
		
	void OnCollisionEnter (Collision other){
		
		if (other.gameObject.CompareTag ("Wall")) {
			Debug.Log ("Game over now");
			gameOver = true;
		}
	}
}
