using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;

public class NextScript : MonoBehaviour
{

    private GameControl gc;
    public GameObject counter;
    public GameObject tekst;
    private void Start()
    {
        string mapName= SceneManager.GetActiveScene().name;
        string fileName = ".\\Assets\\Scripts\\Text\\"+ mapName + "Text.txt";
        string data = File.ReadAllText(fileName);
        
        gc = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();
        tekst.GetComponent<TMP_Text>().text = data;
    }


    // Start is called before the first frame update
    public void NextClick()
    {
        gc.isPaused = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked; // odblokowujemy poruszanie kursorem po ekranie
        counter.SetActive(true);

    }
}
