using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Buttons : MonoBehaviour {
    public GameObject MenuPanel;
    public GameObject RulesPanel;
    public GameObject HighscoresPanel;
	// Use this for initialization
	void Start () {
        MenuPanel.SetActive(true);
        RulesPanel.SetActive(false);
        HighscoresPanel.SetActive(false);
	}
	public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
        RulesPanel.SetActive(false);
        HighscoresPanel.SetActive(false);
    }
    public void ShowRulesPanel()
    {
        MenuPanel.SetActive(false);
        RulesPanel.SetActive(true);
        HighscoresPanel.SetActive(false);
    }
    public void ShowHighscoresPanel()
    {
        MenuPanel.SetActive(false);
        RulesPanel.SetActive(false);
        HighscoresPanel.SetActive(true);
    }
}
