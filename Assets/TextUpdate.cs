using UnityEngine;
using System.Collections;

public class TextUpdate : MonoBehaviour {
	public int score;
	public int food;
	private int scoreincrement;
	private int foodincrement;



	public bool gameover;
	// Use this for initialization
	void Start () {
		score = 0;
		food = 100;
		scoreincrement = 0;
		foodincrement = 0;
			}
	
	// Update is called once per frame
	void Update () {
		
			if (foodincrement < 50){
				foodincrement++;
			}else{
			food--;
				foodincrement = 0;
			}

		if (scoreincrement < 30) {
			scoreincrement++;
		} else {
			score++;
			scoreincrement=0;
		}
		 
		print (score);


	}
}
