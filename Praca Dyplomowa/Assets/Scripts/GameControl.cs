using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update

    public int value = 0; // Ilosc zebranych dobrze poszlak

    public GameObject panel;
    private GameObject Counter;
    public GameObject panelEnd;

    public int lngth = 0;
    public int allVal = 0;// Ilosc wszystkich poszlak - zle i dobrze zebranych

    public bool isPaused = false;

    public void Start()
    {
        Time.timeScale = 1;
        GameObject parentObject = GameObject.Find("Poszlaki");
        lngth = parentObject.transform.childCount;
        Counter = GameObject.Find("Licznik");


    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
            Time.timeScale = 0;
            Cursor.visible = true; // wlaczamy widocznosc kursora
            Cursor.lockState = CursorLockMode.None; // odblokowujemy poruszanie kursorem po ekranie
            panel.SetActive(true);
            

        }
        if (allVal >=lngth)// konczenie mapy
        {
            Counter.SetActive(false);
            Time.timeScale = 0;
            Cursor.visible = true; // wlaczamy widocznosc kursora
            Cursor.lockState = CursorLockMode.None; // odblokowujemy poruszanie kursorem po ekranie
            panelEnd.SetActive(true);
        }
    }


}
