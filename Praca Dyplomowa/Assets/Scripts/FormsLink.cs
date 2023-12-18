using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FormsLink : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject scene1, scene2;
    public string open = Application.streamingAssetsPath + "/FirstTimeOpening.txt";

    void Start()
    {
        string [] x = File.ReadAllLines(open);
        Debug.Log(x[0]);
        if (x[0]=="2")
        {
            scene2.SetActive(true);
            scene1.SetActive(false);
        }
    }

    public void ButtonClick()
    {
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSfV9ibVDaC-H8vm0lxV2jzljaX0qui9eWysw9I9ZnvVUMxB0A/viewform?fbclid=IwAR0LZ-6WBlz0y3ast1K4KzoNnGLsyQ5E7lSAo9LvEijWqrrAXaPbsn7kZ4A");
        File.WriteAllText(open, "2");
    }



    // Update is called once per frame

}
