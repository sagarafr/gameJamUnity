using UnityEngine;
using System.Collections;

public class Move_of_missile : MonoBehaviour {

    private int force = 500;

	// Use this for initialization
	void Start () {
       GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 0, 0) * force, ForceMode2D.Force);
        }
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Rigidbody2D>() != null)
        {
            if (GetComponent<Rigidbody2D>().transform.position.x > 15)
            {
                Destroy(GetComponent<Rigidbody2D>(), 1);
            }
        }
    }
}
