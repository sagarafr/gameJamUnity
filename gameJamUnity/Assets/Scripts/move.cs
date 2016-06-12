using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public GameObject pos;

    void Start () {
	}

    void Update () {
        Debug.Log(Screen.width + " " + Screen.height);
        if ((Input.GetKey("up") || (Input.GetKey("z"))) && pos.transform.position.y < 4.8)
        {
            transform.Translate(new Vector3(0, (float)0.1, 0));
        }
        if ((Input.GetKey("left") || (Input.GetKey("q"))) && pos.transform.position.y > -15)
        {
            transform.Translate(new Vector3((float)-0.1, 0, 0));
        }
        if ((Input.GetKey("right") || (Input.GetKey("d"))) && pos.transform.position.y < 15)
        {
            transform.Translate(new Vector3((float)0.1, 0, 0));
        }
        if ((Input.GetKey("down") || (Input.GetKey("s"))) && pos.transform.position.y > -4.8)
        {
            transform.Translate(new Vector3(0, (float)-0.1, 0));
        }
    }
}
