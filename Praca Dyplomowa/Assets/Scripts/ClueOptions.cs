using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class ClueOptions : ObjectClickEvent
{
    
    public void ChoiceOption1() // akcja po wcisnieciu 1 guzika
    {
        AddingValue(0, control, ObjectClickEvent.item, ObjectClickEvent.objectTag);
        DialogueClosing(Panel); // Funkcja w DialogueOptions
    }
    public void ChoiceOption2() // akcja po wcisnieciu 2 guzika
    {
        AddingValue(1, control, ObjectClickEvent.item, ObjectClickEvent.objectTag);
        DialogueClosing(Panel);
    }
    public void ChoiceOption3()// akcja po wcisnieciu 3 guzika
    {
        AddingValue(2, control, ObjectClickEvent.item, ObjectClickEvent.objectTag);
        DialogueClosing(Panel);
    }
    public void ChoiceOption4()// akcja po wcisnieciu 4 guzika
    {
        AddingValue(3, control, ObjectClickEvent.item, ObjectClickEvent.objectTag);
        DialogueClosing(Panel);
    }
}
