using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class métorite_1 : MonoBehaviour
{
    private GameObject meteorite_1_gameobject;

    // Use this for initialization
    void Start()
    {
        meteorite_1_gameobject = GameObject.Find("météor_1");
        Debug.Log(meteorite_1_gameobject);
    }
	
	// Update is called once per frame
	void Update ()
    {     
        if (meteorite_1_gameobject.transform.position.x >= -13)
        {
            meteorite_1_gameobject.transform.position = new Vector3(meteorite_1_gameobject.transform.position.x - 1, meteorite_1_gameobject.transform.position.y, meteorite_1_gameobject.transform.position.z);
            meteorite_1_gameobject.transform.rotation = Quaternion.Euler(transform.rotation.x, 90, 90);
        }
	}
}
