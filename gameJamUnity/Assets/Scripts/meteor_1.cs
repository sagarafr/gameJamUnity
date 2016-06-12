using UnityEngine;
using System.Collections;

public class meteor_1 : MonoBehaviour
{
    public Vector3 velocity = new Vector3(0.3F, 0, 0);

	void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
	}

	void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Substring(0, 10) == "Munitions_")
            Destroy(gameObject);
    }
}
