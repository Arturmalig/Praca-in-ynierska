using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update

    public int value = 0; // Ilosc zebranych poszlak

    public GameObject Panel;// Canvas

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true; // wlaczamy widocznosc kursora
            Cursor.lockState = CursorLockMode.None; // odblokowujemy poruszanie kursorem po ekranie
            Panel.SetActive(true);
        }
    }


}
