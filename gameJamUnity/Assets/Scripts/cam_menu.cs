using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cam_menu : MonoBehaviour
{
    public float delay_time = 5;
    public float time_limit_animation = 7;
    public float sound_main_menu = 0.5F;
    public string title = "Red Neck Jack VS The Univers";
    public float delta_sound_main_menu = 0.05F;
    public float delta_move_cam = 6;

    private float timer;
    private Vector3 inital_cam_position;
    private float inital_cam_size;
    private Camera main_cam;
    private AudioSource audio_jack_voice_intro;
    private AudioSource main_menu_music;
    private Text main_title;
    private Button play_button;
    private GameObject play_button_gameobject;
    // Use this for initialization
    void Start ()
    {
        timer = 0;
        inital_cam_position = new Vector3(0, 0, -10);
        inital_cam_size = 5;
        GameObject cam_gameobject = GameObject.Find("Main Camera");
        GameObject audio_gameobject = GameObject.Find("jack_voice_introduction");
        GameObject main_menu_music_gameobject = GameObject.Find("menu_music");
        GameObject main_title_gameobject = GameObject.Find("game_title");
        play_button_gameobject = GameObject.Find("play_button");

        if (cam_gameobject != null)
            main_cam = cam_gameobject.GetComponent<Camera>();

        if (audio_gameobject != null)
            audio_jack_voice_intro = audio_gameobject.GetComponent<AudioSource>();

        if (main_menu_music_gameobject != null)
        {
            main_menu_music = main_menu_music_gameobject.GetComponent<AudioSource>();
            main_menu_music.Stop();
        }

        if (main_title_gameobject != null)
        {
            main_title = main_title_gameobject.GetComponent<Text>();
            Color tmp_color = main_title.color;
            tmp_color.a = 0;
            main_title.color = tmp_color;
        }

        if (play_button_gameobject != null)
        {
            play_button = play_button_gameobject.GetComponent<Button>();
            play_button_gameobject.SetActive(false);
            play_button.onClick.AddListener(play);
        }

    }

	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;

        if (timer >= audio_jack_voice_intro.clip.length)
        {
            main_menu_music.volume = main_menu_music.volume + delta_sound_main_menu;
            if (main_menu_music.volume >= sound_main_menu)
                main_menu_music.volume = sound_main_menu;
        }

        if (timer >= audio_jack_voice_intro.clip.length && !main_menu_music.isPlaying)
            main_menu_music.Play();

        if (timer >= audio_jack_voice_intro.clip.length + delta_move_cam)
        {
            float delta = (timer - audio_jack_voice_intro.clip.length - delta_move_cam) / delay_time;

            main_cam.orthographicSize = main_cam.orthographicSize + delta;
            main_cam.transform.position = new Vector3(main_cam.transform.position.x - delta,
                                                      main_cam.transform.position.y - delta,
                                                        main_cam.transform.position.z + delta);

            if (main_cam.orthographicSize >= inital_cam_size)
                main_cam.orthographicSize = inital_cam_size;

            if (main_cam.transform.position.x <= inital_cam_position.x)
                main_cam.transform.position = new Vector3(inital_cam_position.x, main_cam.transform.position.y, main_cam.transform.position.z);

            if (main_cam.transform.position.y <= inital_cam_position.y)
                main_cam.transform.position = new Vector3(main_cam.transform.position.x, inital_cam_position.y, main_cam.transform.position.z);

            if (main_cam.transform.position.z >= inital_cam_position.z)
                main_cam.transform.position = new Vector3(main_cam.transform.position.x, main_cam.transform.position.y, inital_cam_position.z);

            if (main_cam.transform.position.x == inital_cam_position.x &&
                main_cam.transform.position.y == inital_cam_position.y &&
                main_cam.transform.position.z == inital_cam_position.z)
            {
                Color tmp = main_title.color;
                tmp.a = 1;
                main_title.color = tmp;
                play_button_gameobject.SetActive(true);
            }
        }
    }

    void play()
    {
        SceneManager.LoadScene("game");
    }
}
