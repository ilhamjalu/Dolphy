using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    public Canvas canvas;
    public Button pause;
    public Button resume;
    public Button exit;
    public GameObject Menu;
    public AudioSource Sound;

	// Update is called once per frame
	public void Berhenti () {
        Menu.SetActive(true);
        Time.timeScale = 0;
        Sound.Stop();
	}

    public void Lanjut()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
        Sound.Play();
    }

    public void Keluar()
    {
        Application.Quit();
    }
}
