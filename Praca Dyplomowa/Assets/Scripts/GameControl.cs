using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update

    public int value = 0; // Ilosc zebranych dobrze poszlak

    public GameObject panel;
    public GameObject Counter;
    public GameObject panelEnd;
    public GameObject panelClick;

    public int lngth = 0;
    public int allVal = 0;// Ilosc wszystkich poszlak - zle i dobrze zebranych

    public bool isPaused = false;

    public void Start()
    {
        Time.timeScale = 0;
        isPaused = true;
        GameObject parentObject = GameObject.Find("Poszlaki");
        lngth = parentObject.transform.childCount;
        Counter = GameObject.Find("Licznik");
        Counter.SetActive(false);

    }

    public void Update()
    {
        if(isPaused)
        {
            Cursor.visible = true; // wlaczamy widocznosc kursora
            Cursor.lockState = CursorLockMode.None; // odblokowujemy poruszanie kursorem po ekranie
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked; // odblokowujemy poruszanie kursorem po ekranie
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            panelClick.SetActive(false);
            panelEnd.SetActive(false);
            isPaused = true;
            Time.timeScale = 0;

            panel.SetActive(true);
            

        }
        if (allVal >=lngth)// konczenie mapy
        {
            Counter.SetActive(false);
            Time.timeScale = 0;
            isPaused = true;
            panelEnd.SetActive(true);
        }
    }


}
