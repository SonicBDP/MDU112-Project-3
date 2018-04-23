using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour {

	public static StatManager Instance;
	void Awake()
	{
		Instance = this;
	}

	public Text stats;

	public void ShowStats(int lvl, int hp_cur, int hp_max, int str)
	{
		Debug.Log("Print stats");
		stats.text = "Lvl: " + lvl.ToString() + " HP: " + hp_cur.ToString() + "/" + hp_max.ToString() + " Strength: " + str.ToString();
	}
}
