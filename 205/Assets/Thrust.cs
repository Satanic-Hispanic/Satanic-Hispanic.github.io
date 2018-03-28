using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour {

	public Rigidbody rb;
	public float powerAmt;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	//uses simple movement
	void FixedUpdate () {
		// this code makes the player move Forward
		if (Input.GetKey (KeyCode.W)) {
			rb.AddForce (Vector3.forward * powerAmt);
		}
		// this code makes the player move Left
		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (Vector3.left * powerAmt);
		}
		// this code makes the player move Back
		if (Input.GetKey (KeyCode.S)) {
			rb.AddForce (Vector3.back * powerAmt);
		}
		// this code makes the player move Right
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (Vector3.right * powerAmt);
		}
	}
}
