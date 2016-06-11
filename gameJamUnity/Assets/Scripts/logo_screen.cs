using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logo_screen : MonoBehaviour
{
    public float delay_time = 5;
    public bool done = false;

    private float timer;
    private Text text_logo;
	// Use this for initialization
	void Start ()
    {
        timer = 0;
        text_logo = null;
        StartCoroutine("LoadScreen");
        GameObject text_logo_gameobject = GameObject.Find("text_logo");
        if (text_logo_gameobject != null)
        {
            text_logo = text_logo_gameobject.GetComponent<Text>();
            Color tmp_color = text_logo.color;
            tmp_color.a = 0F;
            text_logo.color = tmp_color;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if (text_logo != null)
        {
            Color tmp_color = text_logo.color;
            tmp_color.a = timer / delay_time;
            if (tmp_color.a >= 1F)
                tmp_color.a = 1F;
            text_logo.color = tmp_color;
        }
        if (timer < delay_time)
            return;
        if (done)
        SceneManager.LoadScene("menu");
	}

    IEnumerator LoadScreen()
    {
        yield return null;
        done = true;
    }
}
