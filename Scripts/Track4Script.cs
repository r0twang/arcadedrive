using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Track4Script : MonoBehaviour {

    void OnGUI()
    {
        if (GUI.Button(new Rect(5, 5, 100, 100), "Dashboard"))
        {
            SceneManager.LoadScene("citySelect");
        }
        if (GUI.Button(new Rect(5, 150, 100, 50), "Car Select"))
        {
            SceneManager.LoadScene("carSelect");
        }
        if (GUI.Button(new Rect(5, 250, 100, 50), "Exit"))
        {
            Application.Quit();
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
