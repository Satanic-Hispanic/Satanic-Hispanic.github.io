using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

	NavMeshAgent nav;
	public Transform M_Player;
	public string target;

		// Use this for initialization
		void Start () {


		}

		// Update is called once per frame
		void Update ()

		{

			GetComponent<NavMeshAgent>().destination = M_Player.position;
		}

	void OnCollisionStay(Collision col){
		Debug.Log("collision w/ " + col.gameObject.name);
		if (col.transform == M_Player){
			//Destroy(M_Player.gameObject);
			//M_Player.gameObject.SetActive(false);
			Debug.Log ("Hit");
		}
	}
}
