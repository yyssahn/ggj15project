using UnityEngine;
using System.Collections;
public class playerController : MonoBehaviour
{
	public float xpos;
	public float ypos;
	private Animator animator;
	
	public GameObject avocado;
	// Use this for initialization
	void Start()
	{
		xpos = 0;
		ypos = 0;
		animator = this.GetComponent<Animator>();
	}
	void OnCollisionEnter2D(Collision2D collection){
		if (collection.gameObject.name == "snake_3") {
			VariablesControl.Damage ();
			renderer.material.color = Color.red;
		}
		if (collection.gameObject.name=="avocadoPrefab(Clone)"){
			Destroy(collection.gameObject);
			VariablesControl.Heal();
			int x, y, z;
			x = UnityEngine.Random.Range (-10, 10);
			y = UnityEngine.Random.Range (-10, 10);
			z = 0;
			
			Instantiate (avocado, new Vector3(x,y,z), Quaternion.identity);
		}
	}

	void OnCollisionStay2D(Collision2D collection) {
		if (collection.gameObject.name == "snake_3") {
						VariablesControl.Damage ();
						renderer.material.color = Color.red;
				}
		}
	void OnCollisionExit2D(Collision2D collection) {
		renderer.material.color = Color.white;
	}
	// Update is called once per frame
	void Update()
	{
		
		//var vertical = Input.GetAxis("Vertical");
		//var horizontal = Input.GetAxis("Horizontal");
		if (Input.GetKey (KeyCode.UpArrow))
		{
			transform.Translate (Vector3.up * 5 * Time.deltaTime);
			ypos = transform.position.x;
			animator.SetInteger("Direction", 2);
		}
		else if (Input.GetKey (KeyCode.DownArrow))
		{
			transform.Translate (Vector3.down * 5 * Time.deltaTime);
			ypos = transform.position.x;
			animator.SetInteger("Direction", 0);
		}
		else if (Input.GetKey (KeyCode.LeftArrow))
		{
			transform.Translate (Vector3.left * 5 * Time.deltaTime);
			xpos = transform.position.x;
			animator.SetInteger("Direction", 1);
			
		}
		else if (Input.GetKey (KeyCode.RightArrow))
		{
			transform.Translate (Vector3.right * 5 * Time.deltaTime);
			xpos = transform.position.x;
			animator.SetInteger("Direction", 3);
		}
		else if(Input.anyKey == false){
			animator.SetInteger ("Direction", 5);
		}
	}
	
}