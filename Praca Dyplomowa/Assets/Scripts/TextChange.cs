using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Globalization;
using UnityEngine.UI;
using Unity.VisualScripting;

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
        string path = ".\\Assets\\Scripts\\Photos\\" + data + ".png";
        if (System.IO.File.Exists(path))
        {
            fileData = File.ReadAllBytes(path);
            Texture2D tex = new Texture2D(300, 370);
            tex.LoadImage(fileData);
            photos.SetActive(true);
            return tex;
        }
        else return null;

    }
    public void TextChanging(string info)
    {
        tutTag = info;
        text.GetComponent<TMP_Text>().text = File.ReadAllText(".\\Assets\\Scripts\\Text\\" + info + "Info.txt");
        string path = ".\\Assets\\Scripts\\Photos\\" + info + ".png";
        if (System.IO.File.Exists(path)) photoButton.gameObject.SetActive(true);
        else photoButton.gameObject.SetActive(false);

    }

    public void ShowPhoto()
    {
        
        photos.GetComponent<RawImage>().texture = PhotoChange(tutTag);

    }
}
