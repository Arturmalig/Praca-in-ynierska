using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public GameObject Tekst;// Tekst licznika na canvas
    private GameControl control;

    private void Start()
    {
        control = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();
        Tekst.GetComponent<TMP_Text>().text = "Collected clues: " + control.allVal + "/" + control.lngth;

    }
    void Update()
    {
        Tekst.GetComponent<TMP_Text>().text = "Collected clues: " + control.allVal + "/" + control.lngth;
    }
}
