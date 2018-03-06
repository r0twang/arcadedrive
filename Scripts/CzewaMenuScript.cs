using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CzewaMenuScript : MonoBehaviour {

    public Canvas czewaMenuCanvas;
    public bool czewaMenuOpen = false;

	// Use this for initialization
	void Start () {
        //czewaMenuCanvas.enabled = false;
        czewaMenuCanvas.GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InfoPanel()
    {
        if (czewaMenuOpen == false)
        {
            czewaMenuOpen = true;
            //czewaMenuCanvas.enabled = true;
            czewaMenuCanvas.GetComponent<Canvas>().enabled = true;
        }
        else if (czewaMenuOpen == true)
        {
            czewaMenuOpen = false;
            //czewaMenuCanvas.enabled = false;
            czewaMenuCanvas.GetComponent<Canvas>().enabled = false;
        }
    }

    public void OnMouseClickDown()
    {
        czewaMenuOpen = false;
        czewaMenuCanvas.GetComponent<Canvas>().enabled = false;
    }
}
