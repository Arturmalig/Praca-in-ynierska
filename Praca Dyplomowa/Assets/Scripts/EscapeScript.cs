using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeScript : MonoBehaviour
{
    public GameControl gc;

    public void Start()
    {
        gc = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();
    }
    public void Resume()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        gc.isPaused = false;
    }

    public void Back()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Quit()
    {

        Application.Quit();
    }
}
