using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timer;
	int x = 1;

	void Start()
	{
		timer = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		counter();
	}

	void counter()
	{
		float seconds_tot = x * Time.deltaTime;
		float minutes = Mathf.FloorToInt(seconds_tot/60);
		float seconds = Mathf.RoundToInt(seconds_tot - (minutes*60));
		timer.text = minutes.ToString("0") + "m " + seconds.ToString("0") + "s";
		x ++;
	}
}
