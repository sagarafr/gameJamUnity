using UnityEngine;
using System.Collections;

public class player_collision : MonoBehaviour {

    // Use this for initialization
    void Start()
    {}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Substring(0, 10) != "Munitions_" && other.name != "Sprite_Redneck_ship")
        {
            life_player.instance.remove_life();
            Destroy(other.gameObject);
        }
    }
}
