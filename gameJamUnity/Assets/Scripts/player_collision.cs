using UnityEngine;
using System.Collections;

public class player_collision : MonoBehaviour
{
    private AudioSource collision_sound;
    // Use this for initialization
    void Start()
    {
        GameObject collision_sound_gameobject = GameObject.Find("collision_sound");

        if (collision_sound_gameobject != null)
        {
            collision_sound = collision_sound_gameobject.GetComponent<AudioSource>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Substring(0, 10) != "Munitions_" && other.name != "Sprite_Redneck_ship")
        {
            life_player.instance.remove_life();
            Destroy(other.gameObject);
            collision_sound.Play();
        }
    }
}
