using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScript : MonoBehaviour
{

    private GameControl gc;
    public GameObject Counter;
    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();
    }

    // Start is called before the first frame update
    public void NextClick()
    {
        gc.isPaused = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked; // odblokowujemy poruszanie kursorem po ekranie
        Counter.SetActive(true);

    }
}
