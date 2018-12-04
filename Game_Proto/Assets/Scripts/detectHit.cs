using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class detectHit : MonoBehaviour {

	public Slider healthbar;
	Animator anim;
	public string targetTag;

	void OnTriggerEnter(Collider col){

		if (col.gameObject.CompareTag(targetTag)) {
			healthbar.value -= 20;
		}

		if (healthbar.value <= 0) 
			anim.SetBool ("isDead", true);
	}

	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
