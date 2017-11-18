using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginLevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void gotoLevel1()
	{
		SceneManager.LoadScene("Interaction1",LoadSceneMode.Single);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
