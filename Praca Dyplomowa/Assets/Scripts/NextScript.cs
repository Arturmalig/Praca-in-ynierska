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
        gc = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();
        string mapName= SceneManager.GetActiveScene().name;

        TextAsset txt = Resources.Load<TextAsset>("Text/" + mapName + "Text");
        tekst.GetComponent<TMP_Text>().text = txt.text;
    }


    // Start is called before the first frame update
    public void WearGlovesClick()
    {
        gc.isPaused = false;
        Time.timeScale = 1;
        counter.SetActive(true);
        gc.glovesEquiped = true;
    }
    public void DontWearGlovesClick()
    {
        gc.isPaused = false;
        Time.timeScale = 1;
        counter.SetActive(true);
        gc.glovesEquiped = false;
    }
}
