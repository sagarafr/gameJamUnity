using UnityEngine;
using System.Collections;

public class starwars_text : MonoBehaviour {

	public float speed;

	// Update is called once per frame
	void Update () {
		Vector3 vec = transform.position;
		vec.z = vec.z + speed;
		transform.position = vec;
	}
}
