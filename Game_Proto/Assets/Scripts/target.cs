using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

	public Animator anim;
	public float health = 100f;
	public GameObject enemyChase;
	public BoxCollider enemyCollide;

	void start(){
		anim = GetComponent<Animator>();
	}

	public void TakeDamage (float amount){
		health -= amount;

		if (health <= 0f) {
			die ();
			enemyChase.GetComponent<Chase> ().enabled = false;
			enemyCollide.enabled = false;
		}
	}
	void die(){
		//Destroy (gameObject);
		anim.SetBool ("isDead", true);
	}
}
