using UnityEngine;
using System.Collections;

public class endscript : MonoBehaviour {
	
	float a=0.0f;
	bool trigger=false;

	Color fontColor=Color.white;
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.Space)) {
			Application.LoadLevel ("testscene");
		}
	}
	
	void OnGUI(){
		a++;
		
		if(a%60==0)
			trigger=!trigger;
		
		if(trigger)
			fontColor.a=0;
		else
			fontColor.a=1;
		
		gameObject.guiText.material.color=fontColor;
	}
	
	
	
}
