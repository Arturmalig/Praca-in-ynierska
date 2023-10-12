using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class DialogueOptions : MonoBehaviour
{
    public class OptionChoice // zmienna sluzaca do tworzenia nizej tablic
    {
        public string text { get; set; }
        public int value { get; set; }
    }
    public OptionChoice[] bloodOp = new OptionChoice[] // tablica zawierajaca opcje na buttony kiedy klikniemy na krew
    {
        new OptionChoice { text = "Zbierz", value = 1},
        new OptionChoice { text = "Poliz", value = 0},
        new OptionChoice { text = "Pomaluj", value = 0},
        new OptionChoice { text = "OdejdŸ", value = 2}

    };

    public OptionChoice[] knifeOp = new OptionChoice[] // tablica zawierajaca opcje na buttony kiedy klikniemy na noz
    {
        new OptionChoice { text = "Zabezpiecz", value = 1},
        new OptionChoice { text = "Dzgnij", value = 0},
        new OptionChoice { text = "Pomachaj", value = 0},
        new OptionChoice { text = "OdejdŸ", value = 2}

    };

    public void DialReturn(GameObject tekst, Button op1, Button op2, Button op3, Button op4, string tag) // funkcja zwracajaca odpowiednie napisy na buttonach w zaleznosci od nacisnietego przedmiotu
    {
        
        if (tag == "blood") // Wprowadzanie linii dialogowych i opcji na przyciskach dla krwii
        {
            // Linia dialogowa
            tekst.GetComponent<TMP_Text>().text = "Dotknales krwi lol";
            //Opcje na przyciskach
            op1.GetComponentInChildren<TMP_Text>().text = bloodOp[0].text;
            op2.GetComponentInChildren<TMP_Text>().text = bloodOp[1].text;
            op3.GetComponentInChildren<TMP_Text>().text = bloodOp[2].text;
            op4.GetComponentInChildren<TMP_Text>().text = bloodOp[3].text;
            // Tworzenie tablicy do zwrotu - MOZE DO ZROBIENIA LOSOWA KOLEJNOSC DIALOGOW

        }
        if (tag == "knife") // Wprowadzanie linii dialogowych i opcji na przyciskach dla no¿a
        {
            // Linia dialogowa
            tekst.GetComponent<TMP_Text>().text = "Dotknales noza hehe";
            //Opcje na przyciskach
            op1.GetComponentInChildren<TMP_Text>().text = knifeOp[0].text;
            op2.GetComponentInChildren<TMP_Text>().text = knifeOp[1].text;
            op3.GetComponentInChildren<TMP_Text>().text = knifeOp[2].text;
            op4.GetComponentInChildren<TMP_Text>().text = knifeOp[3].text;
            // Tworzenie tablicy do zwrotu - MOZE DO ZROBIENIA LOSOWA KOLEJNOSC DIALOGOW

        }
    }

    List<int> tab = new List<int>();
    public void ValueReturn(string tag)
    {
        if(tag=="blood")
        {
            tab.Add(bloodOp[0].value);
            tab.Add(bloodOp[1].value);
            tab.Add(bloodOp[2].value);
            tab.Add(bloodOp[3].value);
        }
        if(tag=="knife")
        {
            tab.Add(knifeOp[0].value);
            tab.Add(knifeOp[1].value);
            tab.Add(knifeOp[2].value);
            tab.Add(knifeOp[3].value);
        }
    }

    public void DialogueClosing(GameObject Panel) // Zamykanie okna dialogowego - zabieg estetyczny, zeby w ObjectClickEvent nie powtarzac 4 razy tych samych linijek
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Panel.SetActive(false);
    }

    public void AddingValue(int choice, GameControl gc, GameObject item, string tag) // zwiêkszanie wartoœci value bêdzie dla kilku opcji, na razie tylko testowe na dole, ¿eby by³o
    {
        Debug.Log(tag);
        ValueReturn(tag);
        if (tab[choice] == 0)
        {
            item.SetActive(false);
            Debug.Log("Z³a opcja");
        }
        if (tab[choice] == 1)
        {
            gc.value++; 
            Debug.Log("Dobra opcja");
            item.SetActive(false);
        }
        if(tab[choice] == 2)
        {
            Debug.Log("Odchodzisz");
            
        }
    }
}
