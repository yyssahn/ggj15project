using UnityEngine;
using System.Collections;

using UnityEngine.UI;


public class HealthUpdate : MonoBehaviour {
	private float healthMultiplier;
	Image HealthBar;
	// Use this for initialization
	void Start () {
		HealthBar = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		healthMultiplier = (float) VariablesControl.health / 100;
		print (healthMultiplier);
		HealthBar.rectTransform.sizeDelta = new Vector2 ((200 * healthMultiplier), 5);
		}
}
