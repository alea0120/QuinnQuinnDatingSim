using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugReturnToStart : MonoBehaviour {

	void start()
	{
		
	}
	public void changeToStart()
	{
		SceneManager.LoadScene("StartScreen",LoadSceneMode.Single);
	}

}