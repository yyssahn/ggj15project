using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class woodupdate : MonoBehaviour {
	Text woodText;
	// Use this for initialization
	void Start () {
		woodText = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		
		woodText.text = "Wood : " + VariablesControl.wood + " / 10";
	}
}
