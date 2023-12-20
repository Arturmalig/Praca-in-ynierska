using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public string path;
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");        
    }

    public void QuitGame()
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
