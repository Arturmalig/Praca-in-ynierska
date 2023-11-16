using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Globalization;
using UnityEngine.UI;



public class TextChange : MonoBehaviour
{
    public GameObject text, photos;// Tekst na canvas
    public GameObject photo1, photo2, photo3, photo4;
    public byte[] fileData;

    private void Start()
    {
        text.GetComponent<TMP_Text>().text = "";
    }

    public string Load(string data)
    {

        string wynik = File.ReadAllText(".\\Assets\\Scripts\\Text\\" + data + "Info.txt");
        return wynik;
    }


    public Texture2D PhotoChange(string data, int number)
    {
        string path = ".\\Assets\\Scripts\\Photos\\" + data + "Photo" + number + ".png";
        if (System.IO.File.Exists(path))
        {
            fileData = File.ReadAllBytes(path);
            Texture2D tex = new Texture2D(300, 370);
            tex.LoadImage(fileData);
            return tex;
        }
        else return null;

    }
    public void TextPhotoChanging(string info)
    {
        string data= Load(info);
        text.GetComponent<TMP_Text>().text = data;
        photos.SetActive(true);
        photo1.GetComponent<RawImage>().texture = PhotoChange(info, 1);
        photo2.GetComponent<RawImage>().texture = PhotoChange(info, 2);
        photo3.GetComponent<RawImage>().texture = PhotoChange(info, 3);
        photo4.GetComponent<RawImage>().texture = PhotoChange(info, 4);

    }
}
