using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextUpdate : MonoBehaviour {
	public int score;
	public int food;
	public static int health;
	private int healthincrement;
	private int scoreincrement;
	private int foodincrement;
	public GameObject gameovg;
	Text scoreText;


	public bool gameover;
	// Use this for initialization
	void Start () {
		score = 0;
		food = 100;
		health = 100;
		scoreincrement = 0;
		foodincrement = 0;
		scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
			if (foodincrement < 5){
				foodincrement++;
			}else{
			health--;
				foodincrement = 0;
			}

		if (scoreincrement < 30) {
			scoreincrement++;
		} else {
			score++;
			scoreincrement=0;
		}
		scoreText.text = "Score : " + score;
	}
}
