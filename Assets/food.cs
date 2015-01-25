using UnityEngine;
using System.Collections;

public class food : MonoBehaviour {
	public GameObject foodObject;
	public int numOfFood;
	public float min;
	public float max;



	// Use this for initialization
	void Start () {
		//foodObject = gameObject.GetComponent("banana");
		//GameObject foodObject = Instantiate (Resources.Load("banana", typeof(GameObject)));
		//GameObject foodObject = (GameObject)Resources.Load (
		//numOfFood = 10;
		//min =  -10;
		//max = 10;
 		PlaceFoods ();

		//Vector2 pos = GeneratePos ();

		//Instantiate (foodObject, pos, Quaternion.identity);
		//Instantiate(foodObject,new Vector3(UnityEngine.Random.Range(-3f,3f),UnityEngine.Random.Range(-3f,3f),UnityEngine.Random.Range(-3f,3f)), Quaternion.identity);
				

	}
	
	// Update is called once per frame
	void Update () {

		//generateIsland(10, Vector2(0, 100));
//		for (int i=0; i <= numOfFood; i++) {
//						Instantiate (foodObject, GeneratePos (), Quaternion.identity);
//						
//				}

		
	}
	
	//	Vector2 generateIsland(int numOfObject, Vector2 area) {
//		for (int i=0; i <= numOfFood; i++) {
//			Vector2 pos	= Vector2(Random.value*area.x, Random.value*area.y);	
//			//Instantiate(obj, pos, Quaternion.identity);
//		}
//
//
//	}


	void PlaceFoods() {
		for (int i=0 ; i < numOfFood; i++){
			Instantiate(foodObject, GeneratePos(), Quaternion.identity);
		}

}
	Vector3 GeneratePos() {
		int x, y, z;
		x = (int) Random.Range (min, max);
		y = (int) Random.Range (min, max);
		z = 0;
		return new Vector3 (x, y, z);
	}

}


