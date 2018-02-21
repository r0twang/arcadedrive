using UnityEngine;
using System.Collections;

public class Track8Script: MonoBehaviour {
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(5, 5, 100, 100), "Dashboard"))
		{
			Application.LoadLevel(0);
		}
        if (GUI.Button(new Rect(5, 150, 100, 50), "Car Select"))
        {
            Application.LoadLevel(1);
        }
    }
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
