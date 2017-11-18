using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class progressionScript : MonoBehaviour {

private int currscene = 0;
	public void gotoNextLevel()
	{
		currscene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene((currscene+1),LoadSceneMode.Single);
	}
}
