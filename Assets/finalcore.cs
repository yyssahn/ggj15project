using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class finalcore : MonoBehaviour {
	
	Text score;
	
	
	// Use this for initialization
	void Start () {
		score = gameObject.GetComponent<Text>();
	//	print (gameObject.GetInstanceID());
		score.text = "Score : " +  VariablesControl.score;
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score : ";


	}
}
