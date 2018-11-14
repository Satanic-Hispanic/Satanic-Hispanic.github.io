using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAnim : MonoBehaviour {

	Animator myAnim;

	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		//Running made the model loop animations and not go back to IDLE
		//if (Input.GetKeyDown(KeyCode.LeftShift)){
		//	myAnim.SetInteger("state", -1);
		//}
		myAnim.SetInteger("state", 0);
		if (Input.GetKeyDown(KeyCode.Space)){
			myAnim.SetInteger ("state", 1);
		}
		if (Input.GetKeyDown(KeyCode.W)){
			myAnim.SetInteger("state", 2);
		}
		if (Input.GetKeyDown(KeyCode.T)){
			myAnim.SetInteger("state", 3);
		}
		if (Input.GetKeyDown(KeyCode.Y)){
			myAnim.SetInteger("state", 4);
		}
		if (Input.GetKeyDown(KeyCode.U)){
			myAnim.SetInteger("state", 5);
		}
		if (Input.GetKeyDown(KeyCode.A)){
			myAnim.SetInteger("state", 6);
		}
		if (Input.GetKeyDown(KeyCode.D)){
			myAnim.SetInteger("state", 7);
		}
	}
}
