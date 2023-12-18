using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Globalization;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

public class TextChange : MonoBehaviour
{
    public GameObject text, photos;// Tekst i zdjêcia na canvas
    public byte[] fileData; // tablica do wczytania grafiki zdjêcia
    public string tutTag;
    public Button photoButton;

    private void Start()
    {
        text.GetComponent<TMP_Text>().text = "";
    }

    public Texture2D PhotoChange(string data)
    {
        if (Resources.Load<Texture2D>("Photos/" + data) != null)
        {
            Texture2D tex;
            tex = Resources.Load<Texture2D>("Photos/" + data);
            photos.SetActive(true);
            return tex;
        }
        else return null;

    }
    public void TextChanging(string info)
    {
        tutTag = info;
        TextAsset txt = Resources.Load<TextAsset>("Text/" + info + "Info");
        text.GetComponent<TMP_Text>().text = txt.text;
        if (Resources.Load<Texture2D>("Photos/" + info) != null) photoButton.gameObject.SetActive(true);
        else photoButton.gameObject.SetActive(false);

    }

    public void ShowPhoto()
    {
        
        photos.GetComponent<RawImage>().texture = PhotoChange(tutTag);

    }
}
