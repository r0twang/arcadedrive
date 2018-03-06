﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DistanceScript : MonoBehaviour {

    private Vector3 previousPosition;
    float sumDistance = 0.0f;
    const float czewaKatoDist = 210.0f;

    // Use this for initialization
    void Start () {
        previousPosition = transform.position;
    }

    void DistanceCalculation ()
    {
        float distance = Vector3.Distance(previousPosition, transform.position);
        sumDistance += distance;
        previousPosition = transform.position;


        if (transform.position.y >= czewaKatoDist)
        {
            EnterCarScript.isPlayerInAnyCar = false;
            SceneManager.LoadScene(1);
        }
    }

    void OnGUI()
    {
        GUIStyle boldFont = new GUIStyle();
        boldFont.richText = true;
        boldFont.fontStyle = FontStyle.Bold;

        GUI.contentColor = Color.red;
        GUILayout.Label("<size=20><color=red>Driven distance: " + transform.position.y + " / 500 km</color></size>", boldFont);
    }

    // Update is called once per frame
    void Update () {
        DistanceCalculation();
    }
}