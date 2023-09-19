using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class DialogueOptions : MonoBehaviour
{
    public class OptionChoice // zmienna sluzaca do tworzenia nizej tablic tekst-prawda/falsz
    {
        public string text { get; set; }
        public bool value { get; set; }
    }
    public OptionChoice[] bloodOp = new OptionChoice[] // tablica zawierajaca opcje na buttony kiedy klikniemy na krew
    {
        new OptionChoice { text = "Zbierz", value = true},
        new OptionChoice { text = "Poliz", value = false},
        new OptionChoice { text = "Pomaluj", value = false},
        new OptionChoice { text = "Pogryz", value = false}

    };

    public OptionChoice[] knifeOp = new OptionChoice[] // tablica zawierajaca opcje na buttony kiedy klikniemy na noz
    {
        new OptionChoice { text = "Zabezpiecz", value = true},
        new OptionChoice { text = "Dzgnij", value = false},
        new OptionChoice { text = "Pomachaj", value = false},
        new OptionChoice { text = "Rzuc", value = false}

    };

    public bool[] DialReturn(GameObject tekst, Button op1, Button op2, Button op3, Button op4, string tag) // funkcja zwracajaca odpowiednie napisy na buttonach w zaleznosci od nacisnietego przedmiotu
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
            bool[] tab1 = new bool[]
            {
                bloodOp[0].value, bloodOp[1].value, bloodOp[2].value, bloodOp[3].value
            };
            return tab1;
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
            bool[] tab2 = new bool[]
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
}
