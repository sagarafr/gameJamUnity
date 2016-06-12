using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class update_life : MonoBehaviour
{
    private Text life_text;

	// Use this for initialization
	void Start ()
    {
        GameObject life_text_gameobject = GameObject.Find("life");

        if (life_text_gameobject != null)
        {
            life_text = life_text_gameobject.GetComponent<Text>();
            string tmp_life = "Life : " + life_player.instance.get_life().ToString();
            life_text.text = tmp_life;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        string tmp_life = "Life : " + life_player.instance.get_life().ToString();
        life_text.text = tmp_life;
/*        if (life_player.instance.get_life() <= 0)
            SceneManager.LoadScene("");*/
	}
}
