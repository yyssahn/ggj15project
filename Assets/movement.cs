using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public float xpos;
	public float ypos;
	Camera camera;
	// Use this for initialization
	void Start () {
		xpos = 0;
		ypos = 0;

	}
	
	// Update is called once per frame

	void Update ()
	{

		if (Input.GetKey (KeyCode.RightArrow)) {

			transform.Translate (Vector3.right * 3 * Time.deltaTime);
			xpos = transform.position.x;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * 3 * Time.deltaTime);
			xpos = transform.position.x;


		}
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.up * 3 * Time.deltaTime);
			ypos = transform.position.x;
	
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector3.down * 3 * Time.deltaTime);
		
			ypos = transform.position.x;
		}
		
	}

}
