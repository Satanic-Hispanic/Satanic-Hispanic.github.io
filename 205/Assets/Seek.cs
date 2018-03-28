using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour {

	Rigidbody rb;
	Vector3 targetPos;
	public GameObject TargetObj;
	public float thrustAmt = 10f;

	// Use this for initialization
	void Start () {
		//This referances the rigidbody in my code
		rb = GetComponent<Rigidbody> ();

	}

	// Update is called once per frame
	void FixedUpdate () {
		//Very basic AI that follows the player where ever it goes.
		targetPos = TargetObj.transform.position;
		Vector3 direction = Vector3.Normalize (targetPos - transform.position);
		rb.AddForce (direction * thrustAmt);


	}
}
