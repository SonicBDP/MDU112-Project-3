using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

	Rigidbody rb_fireball;
	Vector3 fb_startpos;
	int fb_dmg = 20;

	// Use this for initialization
	void Start () {
		rb_fireball = GetComponent<Rigidbody> ();
		fb_startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.x < 42.06)								//if the fireball is not at the end of the level 
		{
			transform.position += Vector3.right * Time.deltaTime * 20;	//make it approach the end
		}
		else if (transform.position.x >= 42.06)							//if the fireball is at the end of the level
		{
			transform.position = fb_startpos;							//reset it to the start of the level
		}
	}

	void OnTriggerEnter (Collider newCollider)
	{
		if (newCollider.gameObject.name == "Player")
		{
			PlayerScript.DamagePlayer(fb_dmg);
		}
	}
}
