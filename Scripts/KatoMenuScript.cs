using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatoMenuScript : MonoBehaviour {

    public Canvas katoMenuCanvas;
    public bool katoMenuOpen = false;

    // Use this for initialization
    void Start()
    {
        //czewaMenuCanvas.enabled = false;
        katoMenuCanvas.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InfoPanel()
    {
        if (katoMenuOpen == false)
        {
            katoMenuOpen = true;
            katoMenuCanvas.GetComponent<Canvas>().enabled = true;
        }
        else if (katoMenuOpen == true)
        {
            katoMenuOpen = false;
            katoMenuCanvas.GetComponent<Canvas>().enabled = false;
        }
    }

    public void OnMouseClickDown()
    {
        katoMenuOpen = false;
        katoMenuCanvas.GetComponent<Canvas>().enabled = false;
    }
}
