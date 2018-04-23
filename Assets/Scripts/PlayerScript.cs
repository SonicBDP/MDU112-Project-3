using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {


	//Variables
	Rigidbody rb;
	public int playerXP_Cur;
	public int playerXP_Col;
	public int playerXP_Req;
	public int playerLVL;

	void Start () {
		rb = GetComponent<Rigidbody>();
		playerXP_Cur = 0;
	}
		
	void Update () {


		//Controls
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

	void OnTriggerEnter (Collider newCollider)
	{
		if (newCollider.gameObject.tag == "Coin")
		{
			Debug.Log("You went through a coin");
			playerXP_Cur += 5;
		}
	}

		
}
