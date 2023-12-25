using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ekran : MonoBehaviour
{
    public GameObject panel;
    public Text success;

    public void quit()
    {
        Application.Quit();
    }

    public void buy()
    {
        success.text = "satýn alma baþarýlý";

    }
   

    public void close() 
    {  
        panel.SetActive(false);
        print("kapandý");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
