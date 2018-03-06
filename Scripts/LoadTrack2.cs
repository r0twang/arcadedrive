﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadTrack2 : MonoBehaviour {

    void OnGUI()
    {
        if (GUI.Button(new Rect(15, 15, 100, 50), "Dashboard"))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void ConfirmButton()
    {
        SceneManager.LoadScene("czewa");
    }

    public void ConfirmTrackButton()
    {
        SceneManager.LoadScene("track2");
    }

    // Use this for initialization
    void Start () {
        PlayerPrefs.GetInt("ChosenCar");
        Debug.Log(PlayerPrefs.GetInt("ChosenCar"));
        EnterCarScript.isPlayerInAnyCar = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (gameObject.name == "track2")
                SceneManager.LoadScene(4);
        }
    }
}
