using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class spawn_meteor : MonoBehaviour
{
    private List<GameObject> asteroid;

	void Start ()
    {
        asteroid = new List<GameObject>();
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_1"), new Vector3(0, 0, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_2"), new Vector3(0, 1, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_3"), new Vector3(0, 2, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_1"), new Vector3(0, 3, 0), new Quaternion()));
    }

    void Update()
    {
        Debug.Log(score_player.instance.get_score());
    }
}
