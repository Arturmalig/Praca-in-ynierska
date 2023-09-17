using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagDialogueOption : MonoBehaviour
{
    // Start is called before the first frame update
    public void TagChecker(string tag)
    {
        if (tag == "blood")
        {
            Debug.Log("Clicked blood");
        }
        if (tag == "knife")
        {
            Debug.Log("Clicked knife");
        }
    }
}
