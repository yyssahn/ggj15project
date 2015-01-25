using UnityEngine;
using System.Collections;

public class VariablesControl : MonoBehaviour {

	public static int score;
	public static int health;
	private int healthincrement;
	private int healthincmax;
	private int scoreincrement;
	public GameObject gameovg;
	
	public static bool gameover;

	private GUITexture myGUITexture;
	// Use this for initialization
	void Start () {
		gameover = false;
		score = 0;
		health = 100;
		scoreincrement = 0;
		healthincmax = 50;
		healthincrement = 0;
	}
	public static void Damage(){
		if (health > 5) {
						health -= 5;
				} else {
			health = 0;
			gameover = true;
			Application.LoadLevel("gameoverscene");
				}

		}

	public static void Heal(){
		if (!gameover) {
			health += 5;
			if(health>100){
				health = 100;
			}
				}
		}
	public void reset(){
		gameover = false;
		score = 0;
		health = 100;
		scoreincrement = 0;
		healthincmax = 50;
		healthincrement = 0;
	}
	// Update is called once per frame
	void Update () {
		if (gameover == true) {
						Application.LoadLevel ("gameoverscene");
				} else {
						if (healthincrement < healthincmax) {
								healthincrement++;
						} else {
								health--;
								if (healthincmax > 10) {
										healthincmax -= 5;
								}
								healthincrement = 0;
						}
						if (health == 0) {
								gameover = true;
						}
						if (scoreincrement < 30) {
								scoreincrement++;
						} else {
								score++;
								scoreincrement = 0;
						}

				}		
	}
}
