using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col)
	{//Destorys the player if it is touched by the enemy which this code is applied to
		if (col.gameObject.name == "Player") {
			Destroy (col.gameObject);
		}
	}
}
