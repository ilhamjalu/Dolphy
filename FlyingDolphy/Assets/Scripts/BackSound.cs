using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackSound : MonoBehaviour
{
    public AudioSource Music;
    public Button Sound;

    public void music()
    {
        Music.Stop();
        Sound.GetComponent<Image>().sprite = Resources.Load<Sprite>("sound_1");
    }

}
