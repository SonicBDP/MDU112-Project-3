using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider newCollider)
	{
		if (newCollider.name == "Player")
		{
			Debug.Log("This object is getting destroyed");
			Destroy(this.gameObject);
		}
	}
}
