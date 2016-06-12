using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shoot : MonoBehaviour {

    public GameObject projectile;
    public GameObject origine;
    private int force = 750;
    private int time = 0;
    private List<GameObject> missiles = new List<GameObject>();

    void Start()
    {
    }

    void Update() {
        time += 1;
        if ((Input.GetKey("space") || Input.GetButtonDown("Fire1")) && time >= 50)
        {
            AudioSource audio_to_play;
            audio_to_play = GameObject.Find("shoot_sound").GetComponent<AudioSource>();
            audio_to_play.Play();
            time = 0;
            missiles.Add((GameObject) Instantiate(projectile, origine.transform.position, new Quaternion()));
            for (int i = 0; i < missiles.Count; i++)
            {
                GameObject tmp_gameobject = missiles[i];
                if (tmp_gameobject == null)
                {
                    Destroy(missiles[i], 1);
                    missiles.RemoveAt(i);
                    continue;
                }
                Rigidbody2D tmp = tmp_gameobject.GetComponent<Rigidbody2D>();
                if (tmp == null)
                {
                    Destroy(missiles[i], 1);
                    missiles.RemoveAt(i);
                }
                else
                {
                                   }
                }
        }
    }
}
