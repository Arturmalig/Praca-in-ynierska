using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnMouseEnter()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }
}
