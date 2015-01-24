using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{
	public float xpos;
	public float ypos;
	Camera camera;
	private Animator animator;
	
	// Use this for initialization
	void Start()
	{
		xpos = 0;
		ypos = 0;
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update()
	{
		
		//var vertical = Input.GetAxis("Vertical");
		//var horizontal = Input.GetAxis("Horizontal");

		if (Input.GetKey (KeyCode.UpArrow))
		{
			transform.Translate (Vector3.up * 3 * Time.deltaTime);
			ypos = transform.position.x;
			animator.SetInteger("Direction", 2);
		}
		else if (Input.GetKey (KeyCode.DownArrow))
		{
			transform.Translate (Vector3.down * 3 * Time.deltaTime);
			ypos = transform.position.x;
			animator.SetInteger("Direction", 0);
		}
		else if (Input.GetKey (KeyCode.LeftArrow))
		{
			transform.Translate (Vector3.left * 3 * Time.deltaTime);
			xpos = transform.position.x;
			animator.SetInteger("Direction", 1);

		}
		else if (Input.GetKey (KeyCode.RightArrow))
		{
			transform.Translate (Vector3.right * 3 * Time.deltaTime);
			xpos = transform.position.x;
			animator.SetInteger("Direction", 3);
		}
		else if(Input.anyKey == false){
			animator.SetInteger ("Direction", 5);
		}
	}
}