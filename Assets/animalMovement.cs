﻿using UnityEngine;
using System.Collections;

public class animalMovement : MonoBehaviour {

	private float x_position;
	private float x_position_2;
	private bool toright;
	private int tickinc;
	private int tickmax=30;
	// Use this for initialization
	void Start () {
		x_position = transform.position.x;
		x_position_2 = x_position - 1;
		toright = false;
		tickinc = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		//pos.x = Mathf.PingPong(Time.time, 2);
		if (toright == false) {
						pos.x -= 0.03f;
						tickinc++;
						if (tickinc > tickmax) {
								toright = true;
								tickinc = 0;
						}
				} else {
			pos.x += 0.03f;
			tickinc ++;
			if (tickinc > tickmax) {
				toright = false;
				tickinc = 0;
			}


				}
		transform.position = pos;
	}
}
