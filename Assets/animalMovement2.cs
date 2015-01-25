using UnityEngine;
using System.Collections;

public class animalMovement2 : MonoBehaviour {
	
	private float y_position;
	private float y_position_2;
	private bool toright;
	private int tickinc;
	private int tickmax=30;
	// Use this for initialization
	void Start () {
		y_position = transform.position.y;
		y_position_2 = y_position - 1;
		toright = false;
		tickinc = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		//pos.x = Mathf.PingPong(Time.time, 2);
		if (toright == false) {
			pos.y -= 0.08f;
			tickinc++;
			if (tickinc > tickmax) {
				toright = true;
				tickinc = 0;
			}
		} else {
			pos.y += 0.08f;
			tickinc ++;
			if (tickinc > tickmax) {
				toright = false;
				tickinc = 0;
			}
			
			
		}
		transform.position = pos;
	}
}

