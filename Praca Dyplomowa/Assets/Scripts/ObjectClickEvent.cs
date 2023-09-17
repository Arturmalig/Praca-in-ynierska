using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickEvent : TagDialogueOption
{
    // Start is called before the first frame update

    public Camera mainCamera;
    public float maxClickDistance = 10;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, maxClickDistance))
            {
                if (hit.collider.gameObject == gameObject && Input.GetMouseButtonDown(0))
                {
                    string objectTag = gameObject.tag; // Pobieramy tag obiektu, który zosta³ klikniêty
                    TagChecker(objectTag);
                }
            }
            else Debug.Log("Too far to click");
        }
    }
}
