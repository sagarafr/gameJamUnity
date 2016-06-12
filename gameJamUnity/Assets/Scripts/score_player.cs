using UnityEngine;
using System.Collections;

public class score_player : MonoBehaviour
{
    public static score_player instance;
    private int score = 0;

	// Use this for initialization
	void Start ()
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

    public void add_score(int to_add)
    {
        score += to_add;
    }

    public int get_score()
    {
        return score;
    }
}
