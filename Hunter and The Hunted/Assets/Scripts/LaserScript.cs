using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

	LineRenderer line;


	void Start () 
	{
		line = gameObject.GetComponent<LineRenderer> ();
		line.enabled = false;

		Screen.lockCursor = true;
	}

	void Update () 
	{
		//when I press mouse1
		if (Input.GetButtonDown("Fire1"))
		{
			StopCoroutine ("FireLaser");
			StartCoroutine ("FireLaser");
		}
	}

	IEnumerable FireLaser ()
	{
		//checks if it is enabled each and every frame
		line.enabled = true;
		//
		while (Input.GetButton ("Fire1")) 
		{
			//
			Ray ray = new Ray (transform.position, transform.forward);

			//
			line.SetPosition (0, ray.origin);
			line.SetPosition (0, ray.GetPoint (100));

			//
			yield return null;
		}
		//
		line.enabled = false;
	}


}
