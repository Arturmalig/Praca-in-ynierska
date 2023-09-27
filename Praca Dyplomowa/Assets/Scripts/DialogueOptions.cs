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
        new OptionChoice { text = "Poliz", value = 2},
        new OptionChoice { text = "Pomaluj", value = 3},
        new OptionChoice { text = "Pogryz", value = 4}

    };

    public OptionChoice[] knifeOp = new OptionChoice[] // tablica zawierajaca opcje na buttony kiedy klikniemy na noz
    {
        new OptionChoice { text = "Zabezpiecz", value = 1},
        new OptionChoice { text = "Dzgnij", value = 2},
        new OptionChoice { text = "Pomachaj", value = 3},
        new OptionChoice { text = "Rzuc", value = 4}

    };

    public int[] DialReturn(GameObject tekst, Button op1, Button op2, Button op3, Button op4, string tag) // funkcja zwracajaca odpowiednie napisy na buttonach w zaleznosci od nacisnietego przedmiotu
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
            int[] tab1 = new int[]
            {
                bloodOp[0].value, bloodOp[1].value, bloodOp[2].value, bloodOp[3].value
            };
            return tab1;
        }
        if (tag == "knife") // Wprowadzanie linii dialogowych i opcji na przyciskach dla no�a
        {
            // Linia dialogowa
            tekst.GetComponent<TMP_Text>().text = "Dotknales noza hehe";
            //Opcje na przyciskach
            op1.GetComponentInChildren<TMP_Text>().text = knifeOp[0].text;
            op2.GetComponentInChildren<TMP_Text>().text = knifeOp[1].text;
            op3.GetComponentInChildren<TMP_Text>().text = knifeOp[2].text;
            op4.GetComponentInChildren<TMP_Text>().text = knifeOp[3].text;
            // Tworzenie tablicy do zwrotu - MOZE DO ZROBIENIA LOSOWA KOLEJNOSC DIALOGOW
            int[] tab2 = new int[]
            {
                 knifeOp[0].value,  knifeOp[1].value,  knifeOp[2].value,  knifeOp[3].value
                 
            };

            return tab2;
        }
        else return null;
    }

    public void DialogueClosing(GameObject Panel) // Zamykanie okna dialogowego - zabieg estetyczny, zeby w ObjectClickEvent nie powtarzac 4 razy tych samych linijek
    {
        Panel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void AddingValue(int choice, GameControl gc)
    {
        if (choice == 1)
        {
            gc.value++; //dodaje warto�� 4 razy???
            Debug.Log(gc.value);
        }
        if(choice == 2)
        {
            Debug.Log(gc.value);
        }
        if (choice == 3)
        {
            Debug.Log(gc.value);
            
        }
        if (choice == 4)
        {
            Debug.Log(gc.value);
        }
    }
}
