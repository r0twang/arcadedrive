using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Track3Script : MonoBehaviour {

    void OnGUI()
    {
        if (GUI.Button(new Rect(5, 5, 100, 100), "Dashboard"))
        {
            SceneManager.LoadScene(1);
        }
        if (GUI.Button(new Rect(5, 150, 100, 50), "Car Select"))
        {
            SceneManager.LoadScene(0);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
