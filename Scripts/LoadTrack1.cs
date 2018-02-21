using UnityEngine;
using System.Collections;

public class LoadTrack1 : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(15, 20, 100, 50), "Track1"))
		{
			Application.LoadLevel(2);
		}
        if (GUI.Button(new Rect(15, 180, 100, 50), "Car Select"))
        {
            Application.LoadLevel(1);
        }
        //hover = GUI.tooltip;

        //if (hover == "Track1")
        //{
        //    Debug.Log("Track1");
        //}
    }

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update () {
		foreach(Touch touch in Input.touches)
		{
			if(gameObject.name == "Track1")
				Application.LoadLevel(2);
		}
    }
}
