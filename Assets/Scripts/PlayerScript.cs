using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public static PlayerScript Instance;
	void Awake () {
		Instance = this;
	}

	//General variables

	Rigidbody rb;

	//Levelling system variables
	public int playerXP_Cur = 0;
	public int playerXP_Gain = 5;
	public int playerXP_Req = 10;
	public int playerLVL = 1;

	//Stat variables

	public int playerHP_Max = 100;
	public int playerHP_Cur = 100;
	public int playerSTR = 5;
	public bool playerBUFF = false;

	void Start () {
		rb = GetComponent<Rigidbody>();
		playerXP_Cur = 0;
	}


		
	void Update () {


		//Controls
		if (Input.GetKey(KeyCode.A)) 
		{
			rb.AddForce (Vector3.left * 20);
		}
		if (Input.GetKey(KeyCode.D))
		{
			rb.AddForce (Vector3.right * 75);
		}
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			rb.velocity = Vector3.up * 7;
		}

		//Levelling system
		LevelUp();

		//UI
		StatManager.Instance.ShowStats(playerLVL, playerHP_Cur, playerHP_Max, playerSTR, playerBUFF);

	}

	void OnTriggerEnter (Collider newCollider)
	{
		if (newCollider.gameObject.tag == "Coin")
		{
			Debug.Log("You went through a coin");
			playerXP_Cur += playerXP_Gain;
		}

		if (newCollider.gameObject.name == "Aura")
		{
			playerBUFF = true;
		}
	}

	void LevelUp()
	{
		if (playerXP_Cur >= playerXP_Req)
		{
			playerLVL += 1;
			playerXP_Gain = (playerLVL * 5) + (playerXP_Req / 20);
			playerXP_Req = playerLVL * (playerLVL+2) * 7;
			playerHP_Max += 20;
			playerSTR += 5;
		}

	}

	public void DamagePlayer (int dmg) 
	{
		playerHP_Cur = playerHP_Cur - dmg;
		Debug.Log("Player has taken " + dmg + " damage and is now on " + playerHP_Cur + " HP");
	}

		
}
