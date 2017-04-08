using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Show : MonoBehaviour
{
    public Canvas Canvas;
    public Button Back;


    public void Kembali()
    {
        Application.LoadLevel(0);
    }
}
