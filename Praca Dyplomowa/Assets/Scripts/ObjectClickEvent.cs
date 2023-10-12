using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ObjectClickEvent : DialogueOptions
{
    // Start is called before the first frame update

    public Camera mainCamera;// Glowna kamera - sluzy do okreslania klikniecia na obiekt
    public float maxClickDistance = 10;//Maksymalna odleglosc z ktorej mozna kliknac przedmiot
    public GameObject Panel;// Canvas
    public GameObject Tekst;// Tekst dialogu na canvas
    public Button Option1;// Przycisk 1 na canvas
    public Button Option2;// Przycisk 2 na canvas
    public Button Option3;// Przycisk 3 na canvas
    public Button Option4;// Przycisk 4 na canvas
    public static string objectTag;//Tag obiektu, ktory kliknelismy
    public static List<int> tab = new List<int>(); // Tablica wartosci dla przyciskow, zwracana przez DialReturn. Sluzy do okreslania poprawnosci wybranej opcji
    public GameControl control; // sluzy do zmiany ilosci zebranych obiektow
    public static GameObject item;


    private void Start()
    {
        //dodanie akcji jaka ma sie wykonac po kliknieciu przycisku na canvasie
        control = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();

    }

    private void Update()
    {
        
        Cursor.visible = true;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, maxClickDistance)) // sprawdzamy czy w dystansie 10 jednostek udalo nam sie w cos kliknac
            {
                if (hit.collider.gameObject == gameObject && Input.GetMouseButtonDown(0)) // Sprawdzamy czy nacisnelismy na obiekt lewym przyciskiem myszy
                {
                    objectTag = gameObject.tag; // Pobieramy tag obiektu, kt�ry zosta� klikni�ty
                    item = gameObject;
                    DialReturn(Tekst, Option1, Option2, Option3, Option4, objectTag);
                    Cursor.visible = true; // wlaczamy widocznosc kursora
                    Cursor.lockState = CursorLockMode.None; // odblokowujemy poruszanie kursorem po ekranie
                    Panel.SetActive(true); // wlaczamy widocznosc canvas z opcjami wyboru
                }
            }
        }
    }
}
