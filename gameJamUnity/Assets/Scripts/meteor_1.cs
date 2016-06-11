using UnityEngine;
using System.Collections;

public class meteor_1 : MonoBehaviour
{
    public Vector3 velocity = new Vector3(0.3F, 0, 0);
    public string name = "meteor_1";

	void Start ()
    {
        GameObject.Find(name).GetComponent<Rigidbody2D>().velocity = velocity;
	}

	void Update ()
    {
        GameObject.Find(name).GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
