using UnityEngine;
using System.Collections;

public class life_player : MonoBehaviour
{
    public static life_player instance;
    public int nb_life = 3;

    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance.gameObject);
        }
        else
            if (this != instance)
        {
            Destroy(this.gameObject);
        }
    }

    public void remove_life()
    {
        nb_life -= 1;
    }

    public int get_life()
    {
        return nb_life;
    }
}
