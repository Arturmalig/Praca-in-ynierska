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

    public void Start()
    {
        control = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();
    }

    public ItemData LoadJson(string tag)
    {
        ItemData wynik;
        string json = File.ReadAllText(".\\Assets\\Scripts\\Text\\" + tag + "Clue.json");
        wynik = JsonUtility.FromJson<ItemData>(json);
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
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Panel.SetActive(false);
        control.isPaused = false;
        Time.timeScale = 1;

    }

    public void AddingValue(int choice, GameControl gc, GameObject item, string tag) // zwiêkszanie wartoœci value bêdzie dla kilku opcji, na razie tylko testowe na dole, ¿eby by³o
    {
        List<int> tab = new List<int>();
        itemData = LoadJson(tag);
        tab.Add(itemData.value1);
        tab.Add(itemData.value2);
        tab.Add(itemData.value3);
        tab.Add(itemData.value4);
        if (tab[choice] == 0)
        {
            
            item.SetActive(false);
            Debug.Log("Z³a opcja");
            gc.allVal++;
        }
        if (tab[choice] == 1)
        {
            gc.value++; 
            Debug.Log("Dobra opcja");
            item.SetActive(false);
            gc.allVal++;
        }
        if(tab[choice] == 2)
        {
            Debug.Log("Odchodzisz");
            
        }
        
    }
}
