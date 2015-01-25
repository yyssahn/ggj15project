using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public GameObject avocado;
	public int count;
	public int min, max;

	// Use this for initialization
	void Start () {
		PlaceCubes();
	}

	void PlaceCubes() {
		print (count);
		for (int i=0; i<count; i++) {
						Instantiate (avocado, GeneratedPosition (), Quaternion.identity);
				}
	}

	Vector3 GeneratedPosition() {
		int x, y, z;
		x = UnityEngine.Random.Range (min, max);
		y = UnityEngine.Random.Range (min, max);
		z = 0;
		return new Vector3 (x, y, z);
		}
}
