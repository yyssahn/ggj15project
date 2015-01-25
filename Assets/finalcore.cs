using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class findcore : MonoBehaviour {
	
	Text score;
	
	
	public bool gameover;
	// Use this for initialization
	void Start () {
		score = GetComponent<Text>();
		score.text = "Score : ";
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score : ";


	}
}
