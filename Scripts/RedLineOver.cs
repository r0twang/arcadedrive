using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class RedLineOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
        public bool isOver = false;

        public void OnPointerEnter(PointerEventData eventData)
        {
            Debug.Log("Red Line");
            isOver = true;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            isOver = false;
        }

    void OnGUI()
    {
        GUIStyle boldFont = new GUIStyle();
        boldFont.richText = true;
        boldFont.fontStyle = FontStyle.Bold;

        if (isOver)
        {
            GUI.contentColor = Color.red;
            GUILayout.Label("<size=20><color=red>Katowice - Białystok</color></size>", boldFont);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
