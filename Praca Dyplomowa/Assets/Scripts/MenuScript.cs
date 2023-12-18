using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string open = Application.streamingAssetsPath + "/FirstTimeClosing.txt";
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void QuitGame()
    {
        string[] x = File.ReadAllLines(open);
        if (x[0] == "1")
        {
            Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSeeZnpb8dHn-DphL1atNh5f2PEbRv6Y8OLAc6lnCRPCJIcSLQ/viewform?fbclid=IwAR1_SLQGC2UvQX7hXfoFBe07ERhTNunadxxvhCoMdO6OXfJF5WCcC8I84Do");
            File.WriteAllText(open, "2");
        }
            Application.Quit();
    }

}
