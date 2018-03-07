using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrakMenuScript : MonoBehaviour {

    public Canvas krakMenuCanvas;
    public bool krakMenuOpen = false;

    // Use this for initialization
    void Start()
    {
        krakMenuCanvas.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InfoPanel()
    {
        if (krakMenuOpen == false)
        {
            krakMenuOpen = true;
            krakMenuCanvas.GetComponent<Canvas>().enabled = true;
        }
        else if (krakMenuOpen == true)
        {
            krakMenuOpen = false;
            krakMenuCanvas.GetComponent<Canvas>().enabled = false;
        }
    }

    public void OnMouseClickDown()
    {
        krakMenuOpen = false;
        krakMenuCanvas.GetComponent<Canvas>().enabled = false;
    }
}
