using UnityEngine;
using System.Collections;

public class LoadTrack8 : MonoBehaviour {

    //public GameObject hover;

	void OnGUI()
	{
		if(GUI.Button(new Rect(15, 100, 100, 50), "Track8"))
		{
			Application.LoadLevel(2);
		}
        //hover = GUI.tooltip;

        //if (hover == "Track8")
        //{
        //    Debug.Log("Track8");
        //}
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches)
		{
			if(gameObject.name == "Track8")
				Application.LoadLevel(2);
		}
    }
}