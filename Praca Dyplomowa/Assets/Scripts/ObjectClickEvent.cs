using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectClickEvent : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera mainCamera;
    public float maxClickDistance = 10;
    public GameObject Panel;
    public Button Option1;
    public Button Option2;
    public Button Option3;
    public Button Option4;
    private int Choice=0;
    private string objectTag;

    private void Start()
    {
        Option1.onClick.AddListener(ChoiceOption1);
        Option2.onClick.AddListener(ChoiceOption2);
        Option3.onClick.AddListener(ChoiceOption3);
        Option4.onClick.AddListener(ChoiceOption4);
        Panel.SetActive(false);
    }

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
                    objectTag = gameObject.tag; // Pobieramy tag obiektu, który zosta³ klikniêty
                    TagChecker(objectTag);
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    Panel.SetActive(true);
                }
            }
            else Debug.Log("Too far to click");
        }
    }

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

    public void ChoiceOption1()
    {
        Choice = 1;
        Debug.Log("Pressed " + Choice);
        Panel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ChoiceOption2()
    {
        Choice = 2;
        Debug.Log("Pressed " + Choice);
        Panel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ChoiceOption3()
    {
        Choice = 3;
        Debug.Log("Pressed " + Choice);
        Panel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ChoiceOption4()
    {
        Choice = 4;
        Debug.Log("Pressed " + Choice);
        Panel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
