using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBoxUpdate : MonoBehaviour {

	public GameObject button0;
	public GameObject button1;
	public GameObject button2;

	void Start () {
		button0.GetComponentInChildren<Text>().text = "Ya like jazz?";
		button1.GetComponentInChildren<Text>().text = "I sell propane and propane acessories";
		button2.GetComponentInChildren<Text>().text = "QUINNNNN";

	}
	
	
	void Update () {
		
	}
}
