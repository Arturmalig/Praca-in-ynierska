using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ObjectClickEvent : DialogueOptions
{
    // Start is called before the first frame update

    public float maxClickDistance = 10;//Maksymalna odleglosc z ktorej mozna kliknac przedmiot
    public GameObject Panel;// Canvas
    public GameObject Tekst;// Tekst dialogu na canvas
    public Button Option1;// Przycisk 1 na canvas
    public Button Option2;// Przycisk 2 na canvas
    public Button Option3;// Przycisk 3 na canvas
    public Button Option4;// Przycisk 4 na canvas
    public static string objectTag;//Tag obiektu, ktory kliknelismy
    public static GameObject item;
    public Camera cam;



    private void Update()
    {
        

        if(!control.isPaused)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, maxClickDistance)) // sprawdzamy czy w dystansie 10 jednostek udalo nam sie w cos kliknac
                {
                    if (hit.collider.gameObject == gameObject && Input.GetMouseButtonDown(0) && control.glovesEquiped == true) // Sprawdzamy czy nacisnelismy na obiekt lewym przyciskiem myszy
                    {
                        control.isPaused = true;
                        Time.timeScale = 0;
                        objectTag = gameObject.tag; // Pobieramy tag obiektu, który zosta³ klikniêty
                        item = gameObject;
                        DialReturn(Tekst, Option1, Option2, Option3, Option4, objectTag);
                        Panel.SetActive(true); // wlaczamy widocznosc canvas z opcjami wyboru
                    }
                    else if(hit.collider.gameObject == gameObject && Input.GetMouseButtonDown(0) && control.glovesEquiped == false)
                    {
                        control.isPaused = true;
                        Time.timeScale = 0;
                        glovesPanel.SetActive(true);
                        glovesTekst.GetComponent<TMP_Text>().text = "It is too dangerous to touch the clues without first putting on gloves.";


                    }
                }
            }
        }
    }
}
