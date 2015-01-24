using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextUpdate : MonoBehaviour {

	Text scoreText;


	public bool gameover;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

		scoreText.text = "Score : " + VariablesControl.score;
	}
}
