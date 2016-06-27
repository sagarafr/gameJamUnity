using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class game_over : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        StartCoroutine("retrun_menu");
	}
	
	IEnumerator retrun_menu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("menu");
    }
}
