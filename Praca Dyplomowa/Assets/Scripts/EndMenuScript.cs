using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextScenario()
    {

        if(SceneManager.GetActiveScene().name == "First_apartment") SceneManager.LoadScene("Second_apartment");
        else if (SceneManager.GetActiveScene().name == "Second_apartment") SceneManager.LoadScene("Third_apartment");
    }

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
