using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	public GameObject wood;
	public GameObject avocado;
	public int count;
	public int min, max;

	// Use this for initialization
	void Start () {
		PlaceWoods ();
		PlaceCubes();
	}

	void PlaceCubes() {
		for (int i=0; i<count; i++) {
						Instantiate (avocado, GeneratedPosition (), Quaternion.identity);
				}
	}

	void PlaceWoods() {
		for (int i=0; i<13; i++) {
			Instantiate (wood, GeneratedPosition (), Quaternion.identity);
		}
	}

	Vector3 GeneratedPosition() {
		int x, y, z;
		x = UnityEngine.Random.Range (-10, 10);
		y = UnityEngine.Random.Range (-10, 12);
		z = 0;
		return new Vector3 (x, y, z);
		}
}
