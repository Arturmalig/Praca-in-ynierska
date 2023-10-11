using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Tekst;// Tekst licznika na canvas
    public GameControl control;

    private void Start()
    {
        control = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();

    }
    void Update()
    {
        Tekst.GetComponent<TMP_Text>().text = "Zebrane poszlaki: " + control.value;
    }
}
