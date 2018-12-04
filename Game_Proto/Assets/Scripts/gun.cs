using UnityEngine;
using UnityEngine.UI;

public class gun : MonoBehaviour {

	public Camera fpsCam;
	public float damage = 30f;
	public float range = 100f;
	public Slider healthbar;
	public ParticleSystem muzzleFlash;
	public Animator anim;

	void start(){
		anim = GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			muzzleFlash.Play();
			Shoot();
		}
		
	}
	void Shoot(){
		
		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {
			
			Debug.Log (hit.transform.name);

			target target = hit.transform.GetComponent<target>();
			if (target != null) {
				target.TakeDamage (damage);
			}
		}
	}
}
