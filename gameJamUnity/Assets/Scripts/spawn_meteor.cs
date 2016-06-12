using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class spawn_meteor : MonoBehaviour
{
    private List<GameObject> asteroid;

    public int limit = 5;
    void Start ()
    {
        asteroid = new List<GameObject>();
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_1"), new Vector3(12, 0, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_2"), new Vector3(4, -7, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_3"), new Vector3(2, 7, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_1"), new Vector3(12, -2, 0), new Quaternion()));
    }

    void Update()
    {
        Debug.Log(score_player.instance.get_score());
        for (int cpt_spwon = 0; cpt_spwon < asteroid.Count; ++cpt_spwon)
        {
            if (asteroid[cpt_spwon] == null)
                asteroid[cpt_spwon] = ((GameObject)Instantiate(Resources.Load("meteor_1"), new Vector3(3, 0, 0), new Quaternion()));
        }
    }
}
