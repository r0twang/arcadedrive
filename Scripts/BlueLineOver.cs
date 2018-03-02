using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class BlueLineOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isOverBlue = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Blue Line");
        isOverBlue = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isOverBlue = false;
    }

    void OnGUI()
    {
        GUIStyle boldFont = new GUIStyle();
        boldFont.richText = true;
        boldFont.fontStyle = FontStyle.Bold;

        if (isOverBlue)
        {
            GUI.contentColor = Color.red;
            GUILayout.Label("<size=20><color=red>Poznań - Katowice</color></size>", boldFont);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}