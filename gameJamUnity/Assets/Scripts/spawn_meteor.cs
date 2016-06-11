using UnityEngine;
using System.Collections;

public class spawn_meteor : MonoBehaviour
{
    public GameObject[] asteroid;
    private int counter;
    private int countertab;
    private int type;

	void Start ()
    {
        countertab = 0;
        counter = Random.Range(1, 5);
        while (counter > 0)
        {
            type = Random.Range(1, 3);
            if (type == 1)
            {
                asteroid[countertab] = GameObject.Find("meteor_1");
                asteroid[countertab].transform.position = new Vector3(Random.Range(13, 14), Random.Range(-15, 15), 0);
            }
            if (type == 2)
            {
                asteroid[countertab] = GameObject.Find("meteor_2");
                asteroid[countertab].transform.position = new Vector3(Random.Range(0, -15), Random.Range(-15, -16), 0);
            }
            if (type == 3)
            {
               asteroid[countertab] = GameObject.Find("meteor_3");
               asteroid[countertab].transform.position = new Vector3(Random.Range(0, -15), Random.Range(15, 16), 0);
            }
            counter--;
            countertab++;
        }
	}
	
}
