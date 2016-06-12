using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawn_meteor : MonoBehaviour
{
    private List<GameObject> asteroid;
    private int type;

    public int limit = 5;
    void Start ()
    {
        asteroid = new List<GameObject>();
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_1"), new Vector3(12, 0, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_2"), new Vector3(4, -7, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_3"), new Vector3(2, 7, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_1"), new Vector3(12, -2, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_2"), new Vector3(0, -7, 0), new Quaternion()));
        asteroid.Add((GameObject)Instantiate(Resources.Load("meteor_3"), new Vector3(6, 7, 0), new Quaternion()));
    }

    void Update()
    {
        Debug.Log(score_player.instance.get_score());
        for (int cpt_spwon = 0; cpt_spwon < asteroid.Count; ++cpt_spwon)
        {
            if (asteroid[cpt_spwon].transform.position.y > 7)
                    asteroid[cpt_spwon].transform.position = new Vector3(Random.Range(0, 12), -7, 0);
            if (asteroid[cpt_spwon].transform.position.y < -7)
                    asteroid[cpt_spwon].transform.position = new Vector3(Random.Range(0, 12), 7, 0);
            if (asteroid[cpt_spwon] == null)
            {
                type = Random.Range(1, 4);
                if (type == 1)
                    asteroid[cpt_spwon] = ((GameObject)Instantiate(Resources.Load("meteor_1"), new Vector3(Random.Range(12, 13), Random.Range(5, -5), 0), new Quaternion()));
                else if (type == 2)
                    asteroid[cpt_spwon] = ((GameObject)Instantiate(Resources.Load("meteor_2"), new Vector3(Random.Range(0, 12), -7, 0), new Quaternion()));
                else if (type == 3)
                    asteroid[cpt_spwon] = ((GameObject)Instantiate(Resources.Load("meteor_3"), new Vector3(Random.Range(0, 12), 7, 0), new Quaternion()));
            }
        }
    }
}
