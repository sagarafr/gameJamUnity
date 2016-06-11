using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shoot : MonoBehaviour {

    public GameObject projectile;
    public GameObject origine;
    private int force = 500;
    private int time = 0;
    private List<GameObject> missiles = new List<GameObject>();

    void Start()
    {
        if (projectile == null)
            Debug.Log("Is NULL");
    }

    void Update() {
        time += 1;
        if (Input.GetButtonDown("Fire1") && time >= 50)
        {
            time = 0;
            missiles.Add(( GameObject ) Instantiate(projectile, origine.transform.position, new Quaternion()));

            for (int i = 0; i < missiles.Count; i++)
            {
                missiles[i].GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 0, 0) * force, ForceMode2D.Force);
                if (missiles[i].transform.position.x > 15)
                {
                    Destroy(missiles[i], 1);
                    missiles.RemoveAt(i);
                }
            }
        }
    } 
}
