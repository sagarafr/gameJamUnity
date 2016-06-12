using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class starwars_text : MonoBehaviour {

	public float speed;
    public float limit = 100F;

	// Update is called once per frame
	void Update () {
		Vector3 vec = transform.position;
		vec.z = vec.z + speed;
		transform.position = vec;
        if (transform.position.z >= limit)
            SceneManager.LoadScene("game_one");
	}
}
