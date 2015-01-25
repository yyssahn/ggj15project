using UnityEngine;
using System.Collections;

public class VariablesControl : MonoBehaviour {
	public static bool gamewon;
	public static int score;
	public static int health;
	private int healthincrement;
	private int healthincmax;
	private int scoreincrement;
	public GameObject gameovg;
	public static int wood;
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
		wood = 0;
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

	public static void gainWood(){
		wood++;
		if (wood == 10) {
			gamewon = true;
				}
		}

	public static void Heal(){
		if (!gameover) {
			health += 10;
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
		if (gamewon == true) {
			print ("won");

				}
		if (gameover == true) {
						PlayerPrefs.SetInt("score",score);
						if(!PlayerPrefs.HasKey("highscore")){
							PlayerPrefs.SetInt("highscore", score);
						} else{
				if (score > PlayerPrefs.GetInt("highscore")){
					PlayerPrefs.SetInt("highscore",score);
				}

			}
						Application.LoadLevel ("gameoverscene");
				} else {
						if (healthincrement < healthincmax) {
								healthincrement++;
						} else {
								health--;
								if (healthincmax > 7) {
										healthincmax -= 1;
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
