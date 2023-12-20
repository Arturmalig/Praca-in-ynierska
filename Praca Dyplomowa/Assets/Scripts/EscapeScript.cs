using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class EscapeScript : MonoBehaviour
{
    public GameControl gc;
    public string path;
    public void Start()
    {
        gc = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameControl>();
    }
    public void Resume()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        gc.isPaused = false;
    }

    public void Back()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Quit()
    {
        path = Application.persistentDataPath + "/FirstTimeClosing.txt";
        if (!File.Exists(path))
        {
            Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSeeZnpb8dHn-DphL1atNh5f2PEbRv6Y8OLAc6lnCRPCJIcSLQ/viewform?fbclid=IwAR1_SLQGC2UvQX7hXfoFBe07ERhTNunadxxvhCoMdO6OXfJF5WCcC8I84Do");
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write("2");
            }
        }
        Application.Quit();
    }
}
