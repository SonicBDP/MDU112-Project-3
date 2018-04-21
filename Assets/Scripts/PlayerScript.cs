using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) 
		{
			rb.AddForce (Vector3.left * 20);
			Debug.Log ("Moving Left");
		}
		if (Input.GetKey(KeyCode.D))
		{
			rb.AddForce (Vector3.right * 75);
			Debug.Log ("Moving Right");
		}
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			rb.velocity = Vector3.up * 7;
			Debug.Log ("Jump");
		}
	}
}
