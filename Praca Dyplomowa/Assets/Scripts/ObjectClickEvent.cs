using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
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
    private bool choice = false;// NIE JESTEM PEWIEN JESZCZE TEGO ELEMENTU, MOZE BOOLE ZALATWIA JEGO ZADANIE
    private string objectTag;//Tag obiektu, ktory kliknelismy
    private bool[] tab = new bool[] { }; // Tablica wartosci dla przyciskow, zwracana przez DialReturn. Sluzy do okreslania poprawnosci wybranej opcji


    private void Start()
    {
        //dodanie akcji jaka ma sie wykonac po kliknieciu przycisku na canvasie
        Option1.onClick.AddListener(ChoiceOption1);
        Option2.onClick.AddListener(ChoiceOption2);
        Option3.onClick.AddListener(ChoiceOption3);
        Option4.onClick.AddListener(ChoiceOption4);
        // na starcie wylaczenie canvasa
        Panel.SetActive(false);
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, maxClickDistance)) // sprawdzamy czy w dystansie 10 jednostek udalo nam sie w cos kliknac
            {
                if (hit.collider.gameObject == gameObject && Input.GetMouseButtonDown(0)) // Sprawdzamy czy nacisnelismy na obiekt lewym przyciskiem myszy
                {
                    objectTag = gameObject.tag; // Pobieramy tag obiektu, który zosta³ klikniêty
                    tab = DialReturn(Tekst, Option1, Option2, Option3, Option4, objectTag);
                    Cursor.visible = true; // wlaczamy widocznosc kursora
                    Cursor.lockState = CursorLockMode.None; // odblokowujemy poruszanie kursorem po ekranie
                    Panel.SetActive(true); // wlaczamy widocznosc canvas z opcjami wyboru
                }
            }
            else Debug.Log("Too far to click"); // TO ZAPEWNE DO USUNIECIA, SLUZY DO SPRAWDZANIA ODLEGLOSCI Z JAKIEJ DA SIE KLIKNAC
        }
    }


    public void ChoiceOption1() // akcja po wcisnieciu 1 guzika
    {
        choice = tab[0]; // Tu wywala dziwny blad we wszystkich, ustalic ocb
        DialogueClosing(Panel);
        Debug.Log(choice);
    }
    public void ChoiceOption2() // akcja po wcisnieciu 2 guzika
    {
        choice = tab[1];
        DialogueClosing(Panel);
        Debug.Log(choice);
    }
    public void ChoiceOption3()// akcja po wcisnieciu 3 guzika
    {
        choice = tab[2];
        DialogueClosing(Panel);
        Debug.Log(choice);
    }
    public void ChoiceOption4()// akcja po wcisnieciu 4 guzika
    {
        choice = tab[3];
        DialogueClosing(Panel);
        Debug.Log(choice);
    }
}
