using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScript : MonoBehaviour
{



    public void Scene1Play() // klikniecie scena1
    {
        SceneManager.LoadScene("Testing");
    }

    public void Scene2Play() // klikniecie scena2
    {
        SceneManager.LoadScene("First_apartment");
    }
}
