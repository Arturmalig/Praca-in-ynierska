using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueChoice : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Option1;
    public GameObject Option2;
    public GameObject Option3;
    public GameObject Option4;
    public int Choice;

    

    void Update()
    {
        if(Choice >=1)
        {
            Option1.SetActive(false);
            Option2.SetActive(false);
            Option3.SetActive(false);
            Option4.SetActive(false);
            Panel.SetActive(false);

        }
    }

}
