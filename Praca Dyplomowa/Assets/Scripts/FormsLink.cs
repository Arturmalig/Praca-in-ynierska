using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FormsLink : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject scene1, scene2;
    public string path;
    void Start()
    {
        path = Application.persistentDataPath + "/FirstTimeOpening.txt";
        if (!File.Exists(path))
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write("1");
            }
        }
        string[] x = File.ReadAllLines(path);
        if (x[0] == "2")
        {
            scene2.SetActive(true);
            scene1.SetActive(false);
        }
    }

    public void ButtonClick()
    {
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSfV9ibVDaC-H8vm0lxV2jzljaX0qui9eWysw9I9ZnvVUMxB0A/viewform?fbclid=IwAR0LZ-6WBlz0y3ast1K4KzoNnGLsyQ5E7lSAo9LvEijWqrrAXaPbsn7kZ4A");
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.Write("2");
        }
    }
}
