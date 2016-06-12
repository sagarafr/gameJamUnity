using UnityEngine;
using System.Collections;

public class shoot_collision : MonoBehaviour
{
    void Start()
    {}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Substring(0, 10) != "Munitions_" && other.name != "Sprite_Redneck_ship")
        {
            score_player.instance.add_score(10);
            Destroy(gameObject);
        }
    }
}
