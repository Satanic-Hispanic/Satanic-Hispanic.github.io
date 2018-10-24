using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

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
	void FixedUpdate () {
		//we can use the 2 positions to determine the distance apart
		//Vector3.Normalize will convert this into a direction (a vector3 with x/y/z values between -1 and 1)
		if (transform.lossyScale.sqrMagnitude > target.lossyScale.sqrMagnitude) {
			Vector3 direction = Vector3.Normalize (target.position - transform.position);
		} else {
			Vector3 directon = Vector3.Normalize (transform.position - target.position);
		}

	}
	/*
	void OnCollisionEnter(Collision col){ //it creates a new Collision when it executes, storing information about the collision
		Debug.Log ("collision W/ " + GetComponent<Collider> ().gameObject.name);

		if (col.transform == target) {
			
			//Destroy (target.gameObject);
			target.gameObject.SetActive (false);

		}
		}*/
}