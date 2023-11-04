using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update

    public int value = 0; // Ilosc zebranych poszlak

    public GameObject Panel;// Canvas

    public int lngth = 0;

    public bool isPaused = false;

    public void Start()
    {
        Time.timeScale = 1;
        lngth = GameObject.FindGameObjectsWithTag("blood").Length + GameObject.FindGameObjectsWithTag("knife").Length + GameObject.FindGameObjectsWithTag("hammer").Length + GameObject.FindGameObjectsWithTag("cup").Length;
    

    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
            Time.timeScale = 0;
            Cursor.visible = true; // wlaczamy widocznosc kursora
            Cursor.lockState = CursorLockMode.None; // odblokowujemy poruszanie kursorem po ekranie
            Panel.SetActive(true);
            

        }
        if (value >=lngth)// konczenie mapy
        {
            Time.timeScale = 0;
            Cursor.visible = true; // wlaczamy widocznosc kursora
            Cursor.lockState = CursorLockMode.None; // odblokowujemy poruszanie kursorem po ekranie
            Panel.SetActive(true);
        }
    }


}
