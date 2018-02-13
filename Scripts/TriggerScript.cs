using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

    bool departure = false;
    // Use this for initialization
    void Start () {

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        departure = true;
        Debug.Log("You have departed lane");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        departure = false;
    }

    void OnGUI()
    {
        GUIStyle boldFont = new GUIStyle();
        boldFont.richText = true;
        boldFont.fontStyle = FontStyle.Bold;

        if (departure)
        {
            GUI.contentColor = Color.red;
            //GUI.Label(new Rect(5, 5, 100, 50), "You have departed lane");
            GUILayout.Label("<size=20><color=red>You have departed lane</color></size>", boldFont);
        }
    }

    // Update is called once per frame
    void Update () {
	}
}
