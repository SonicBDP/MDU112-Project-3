using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {


	//General variables
	public static PlayerScript Instance;
	Rigidbody rb;


	//Levelling system variables
	public int playerXP_Cur;
	public int playerXP_Col;
	public int playerXP_Req;
	public int playerLVL;

	//Stat variables
	public int playerHP_Max = 100;
	public int playerHP_Cur = 100;
	public int playerSTR = 5;

	void Start () {
		rb = GetComponent<Rigidbody>();
		playerXP_Cur = 0;
	}

	void Awake () {
		Instance = this;
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

	public void DamagePlayer (int dmg) 
	{
		playerHP_Cur = playerHP_Cur - dmg;
		Debug.Log("Player has taken " + dmg + " damage and is now on " + playerHP_Cur + " HP");
	}

		
}
