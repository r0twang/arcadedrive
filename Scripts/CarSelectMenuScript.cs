using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelectMenuScript : MonoBehaviour {

    void OnGUI()
    {
        if (GUI.Button(new Rect(5, 5, 100, 100), "Dashboard"))
        {
            Application.LoadLevel(0);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
