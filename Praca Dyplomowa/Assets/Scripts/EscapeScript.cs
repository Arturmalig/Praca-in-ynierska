using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeScript : MonoBehaviour
{


    public void Back()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Quit()
    {
        Debug.Log("Wychodzenie");

        //Application.Quit();
    }
}
