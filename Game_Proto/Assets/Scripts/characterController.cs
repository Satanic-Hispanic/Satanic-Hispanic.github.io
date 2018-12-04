using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

	static Animator anim;
	public float speed = 10.0f;
	public float rotationSpeed = 50.0f;
	public GameObject strike;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {

		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation);

		if (Input.GetButton ("Fire1")) {
			strike.SetActive (false);
			//Cursor.visible = true;
			anim.SetBool ("isAttacking", true);
		} else 
			anim.SetBool ("isAttacking", false);
		strike.SetActive (false);

		if (translation != 0) {
			anim.SetBool ("isWalking", true);
			anim.SetBool ("isIdle", false);
			strike.SetActive (false);

		} else {
			anim.SetBool ("isWalking", false);
			anim.SetBool ("isIdle", true);
			strike.SetActive (true);
		}
			
		if (Input.GetKeyDown ("escape")) {
			Cursor.lockState = CursorLockMode.None;
		} else {
			Cursor.lockState = CursorLockMode.Locked;
		}
		
	}
}
