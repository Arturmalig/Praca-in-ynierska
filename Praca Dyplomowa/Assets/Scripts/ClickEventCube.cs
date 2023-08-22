using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEventCube : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera mainCamera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject && Input.GetMouseButtonDown(0))
                {
                    Interaction();
                }
            }
        }
    }

    private void Interaction()
    {
        Debug.Log("klikniêto boxa");
    }

}
