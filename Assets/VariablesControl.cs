using UnityEngine;
using System.Collections;

public class VariablesControl : MonoBehaviour {

	public static int score;
	public static int health;
	private int healthincrement;
	private int scoreincrement;
	public GameObject gameovg;

	
	public bool gameover;
	// Use this for initialization
	void Start () {
		gameover = false;
		score = 0;
		health = 100;
		scoreincrement = 0;
		healthincrement = 0;
	}

	public void reset(){
		gameover = false;
		score = 0;
		health = 100;
		scoreincrement = 0;
		healthincrement = 0;
	}
	// Update is called once per frame
	void Update () {
		
		if (healthincrement < 5){
			healthincrement++;
		}else{
			health--;
			healthincrement = 0;
		}
		if (health == 0) {
			gameover = true;
				}

		if (scoreincrement < 30) {
			scoreincrement++;
		} else {
			score++;
			scoreincrement=0;
		}
	}}
