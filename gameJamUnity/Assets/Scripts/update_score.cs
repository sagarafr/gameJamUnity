﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class update_score : MonoBehaviour
{
    private Text score_text;

    public int next_level = 250;
	// Use this for initialization
	void Start ()
    {
        GameObject score_text_gameobject = GameObject.Find("score");

        if (score_text_gameobject != null)
        {
            score_text = score_text_gameobject.GetComponent<Text>();
            string tmp_score = "Score : " + score_player.instance.get_score().ToString();
            score_text.text = tmp_score;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        string tmp_score = "Score : " + score_player.instance.get_score().ToString();
        score_text.text = tmp_score;
        if (score_player.instance.get_score() > next_level)
            SceneManager.LoadScene("transition_game_two");
    }
}
