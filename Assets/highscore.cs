using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class highscore : MonoBehaviour {
	
	Text score;
	int hscore; 
	
	// Use this for initialization
	void Start () {
		score = gameObject.GetComponent<Text>();
		hscore = PlayerPrefs.GetInt ("highscore");
		//	print (gameObject.GetInstanceID());
		score.text = "Highscore : " + hscore;
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
