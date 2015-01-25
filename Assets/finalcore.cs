using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class finalcore : MonoBehaviour {
	
	Text score;
	int localscore;
	int highscore; 
	
	// Use this for initialization
	void Start () {
		score = gameObject.GetComponent<Text>();
		localscore = PlayerPrefs.GetInt ("score");
		highscore = PlayerPrefs.GetInt ("highscore");
		print (highscore);
	//	print (gameObject.GetInstanceID());
		score.text = "Score : " + localscore;
	}
	
	// Update is called once per frame
	void Update () {


	}
}
