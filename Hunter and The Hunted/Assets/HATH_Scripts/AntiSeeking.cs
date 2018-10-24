using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiSeeking : MonoBehaviour {

	Rigidbody myBody;

	//assign the target in the inspector
	public Transform target;

	//we use a forceAmt so we can multiply the direction and it will affect all axes the same
	public float forceAmt;

	// Use this for initialization
	void Start () {
		//assign whichever rigidbody is attached to this gameobject
		myBody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		//we can use the 2 positions to determine the distance apart
		//Vector3.Normalize will convert this into a direction (a vector3 with x/y/z values between -1 and 1)
		Vector3 direction = Vector3.Normalize(transform.position - target.position);

		myBody.AddForce(direction * forceAmt);

	}
	//void OnCollisionEnter(Collision colReport){ //it creates a new Collision when it executes, storing information about the collision
	//	Destroy (gameObject);
	//
	//we check to see if the gameObject collided with (as indicated in the colReport) is the same as our target
	//	if (colReport.gameObject == target) {
	//		Destroy (target);
	//	}
	//}

}