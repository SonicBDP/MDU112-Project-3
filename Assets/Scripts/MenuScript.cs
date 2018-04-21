using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
	
	public void GameScene() 
	{
		SceneManager.LoadScene(1);		//Loads the game scene
	}

	public void CreditScene()
	{
		SceneManager.LoadScene(2);		//Loads the credit scene
	}
}
