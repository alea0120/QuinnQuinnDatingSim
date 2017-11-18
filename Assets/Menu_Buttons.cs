using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Menu_Buttons : MonoBehaviour {
    public GameObject MenuPanel;
    public GameObject SecondPanel;

    void Start () {
        MenuPanel.SetActive(true);
        SecondPanel.SetActive(false);
    }
	
	void Update () {
		
	}
    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
        SecondPanel.SetActive(false);
    }
    public void ShowSecondPanel()
    {
        MenuPanel.SetActive(false);
        SecondPanel.SetActive(true);
    }
}

