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
    public Button Option1;// Przycisk 1 na canvas
    public Button Option2;// Przycisk 2 na canvas
    public Button Option3;// Przycisk 3 na canvas
    public Button Option4;// Przycisk 4 na canvas
    private int Choice=0;// NIE JESTEM PEWIEN JESZCZE TEGO ELEMENTU, MOZE BOOLE ZALATWIA JEGO ZADANIE
    private string objectTag;//tag obiektu, ktory kliknelismy


    private void Start()
    {
        Option1.onClick.AddListener(ChoiceOption1);
        Option2.onClick.AddListener(ChoiceOption2);
        Option3.onClick.AddListener(ChoiceOption3);
        Option4.onClick.AddListener(ChoiceOption4);
        Panel.SetActive(false);
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bool[] tab = new bool[] { };
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, maxClickDistance)) // sprawdzamy czy w dystansie 10 jednostek udalo nam sie w cos kliknac
            {
                if (hit.collider.gameObject == gameObject && Input.GetMouseButtonDown(0)) // Sprawdzamy czy nacisnelismy na obiekt lewym przyciskiem myszy
                {
                    objectTag = gameObject.tag; // Pobieramy tag obiektu, który zosta³ klikniêty
                    tab = DialReturn(Option1, Option2, Option3, Option4, objectTag);
                    Cursor.visible = true; // wlaczamy widocznosc kursora
                    Cursor.lockState = CursorLockMode.None; // odblokowujemy poruszanie kursorem po ekranie
                    Panel.SetActive(true); // wlaczamy widocznosc canvas z opcjami wyboru
                    foreach (bool v in tab) /// FRAGMENT TESTOWY - DO USUNIECIA PAMIETAC
                    {
                        Debug.Log(v.ToString() + " "); 
                    }; /// KONIEC FRAGMENTU TESTOWEGO
                }
            }
            else Debug.Log("Too far to click");
        }
    }


    public void ChoiceOption1() // akcja po wcisnieciu 1 guzika
    {
        Choice = 1;
        Debug.Log("Pressed " + Choice);
        DialogueClosing(Panel);
    }
    public void ChoiceOption2() // akcja po wcisnieciu 2 guzika
    {
        Choice = 2;
        Debug.Log("Pressed " + Choice);
        DialogueClosing(Panel);
    }
    public void ChoiceOption3()// akcja po wcisnieciu 3 guzika
    {
        Choice = 3;
        Debug.Log("Pressed " + Choice);
        DialogueClosing(Panel);
    }
    public void ChoiceOption4()// akcja po wcisnieciu 4 guzika
    {
        Choice = 4;
        Debug.Log("Pressed " + Choice);
        DialogueClosing(Panel);
    }
}
