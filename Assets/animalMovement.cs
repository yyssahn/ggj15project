﻿using UnityEngine;
using System.Collections;

public class animalMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x = Mathf.PingPong(Time.time, 3);
		transform.position = pos;
	}
}
