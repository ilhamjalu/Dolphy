using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {
    public Canvas Start;
    public Button Begin;
    public Button About;
    public Button How;
    public Button Exit;

    public void Mulai()
    {
        Application.LoadLevel(1);
    }

    public void Tentang()
    {
        Application.LoadLevel(2);
    }

    public void Cara()
    {
        Application.LoadLevel(3);
    }

    public void Keluar()
    {
        Application.Quit();
    }
}
