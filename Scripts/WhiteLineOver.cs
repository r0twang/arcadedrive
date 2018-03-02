using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class WhiteLineOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isOverWhite = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("White Line");
        isOverWhite = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isOverWhite = false;
    }

    void OnGUI()
    {
        GUIStyle boldFont = new GUIStyle();
        boldFont.richText = true;
        boldFont.fontStyle = FontStyle.Bold;

        if (isOverWhite)
        {
            GUI.contentColor = Color.red;
            GUILayout.Label("<size=20><color=red>Białystok - Poznań</color></size>", boldFont);
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