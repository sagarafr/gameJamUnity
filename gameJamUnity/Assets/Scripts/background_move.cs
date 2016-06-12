using UnityEngine;
using System.Collections;

public class background_move : MonoBehaviour
{
    public Vector3 movement;
    public float restart_position_x;

    private Camera main_cam;
	// Use this for initialization
	void Start ()
    {
        GameObject main_cam_gameobject = GameObject.Find("Main Camera");

        if (main_cam_gameobject != null)
        {
            main_cam = main_cam_gameobject.GetComponent<Camera>();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 limit;
        Vector3 vector_cam = new Vector3(0, 0, main_cam.nearClipPlane);

        GetComponent<Rigidbody2D>().velocity = movement;
        limit.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        limit.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

        if (transform.position.x < main_cam.ViewportToWorldPoint(vector_cam).x - (limit.x / 2))
        {
            transform.position = new Vector3(restart_position_x, transform.position.y, transform.position.z);
        }
	}
}
