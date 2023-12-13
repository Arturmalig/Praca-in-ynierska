using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;



public class DialogueOptions : MonoBehaviour
{

    public ItemData itemData;
    public GameControl control;
    protected GameObject glovesPanel;
    protected GameObject glovesTekst;

    public void Start()
    {
        control = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();
        glovesPanel = GameObject.FindGameObjectWithTag("StartScreen");
        glovesTekst = GameObject.FindGameObjectWithTag("StartText");
    }

    public ItemData LoadJson(string tag)
    {
        ItemData wynik;
        TextAsset jsonFile = Resources.Load<TextAsset>("Text/" + tag + "Clue");
        wynik = JsonUtility.FromJson<ItemData>(jsonFile.text);
        Debug.Log(wynik);
        return wynik;
    }
    public void DialReturn(GameObject tekst, Button op1, Button op2, Button op3, Button op4, string tag) // funkcja zwracajaca odpowiednie napisy na buttonach w zaleznosci od nacisnietego przedmiotu
    {

        itemData = LoadJson(tag);
        tekst.GetComponent<TMP_Text>().text = itemData.text;
        op1.GetComponentInChildren<TMP_Text>().text = itemData.option1;
        op2.GetComponentInChildren<TMP_Text>().text = itemData.option2;
        op3.GetComponentInChildren<TMP_Text>().text = itemData.option3;
        op4.GetComponentInChildren<TMP_Text>().text = itemData.option4;


    }


    public void DialogueClosing(GameObject Panel) // Zamykanie okna dialogowego - zabieg estetyczny, zeby w ObjectClickEvent nie powtarzac 4 razy tych samych linijek
    {
        Panel.SetActive(false);
        control.isPaused = false;
        Time.timeScale = 1;

    }

    public void AddingValue(int choice, GameObject item, string tag)
    {
        List<int> tab = new List<int>();
        itemData = LoadJson(tag);
        tab.Add(itemData.value1);
        tab.Add(itemData.value2);
        tab.Add(itemData.value3);
        tab.Add(itemData.value4);

        if (tab[choice] == 0) //wartoœæ jest równa 0 - z³a odpowiedŸ
        {
            
            item.SetActive(false);
            control.allVal++;
        }
        if (tab[choice] == 1) //wartoœæ jest równa 1 - dobra odpowiedŸ
        {
            control.value++; 
            item.SetActive(false);
            control.allVal++;
        }

    }
}
