using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadTrack2 : MonoBehaviour {

    void OnGUI()
    {
        if (GUI.Button(new Rect(15, 180, 100, 50), "Track2"))
        {
            SceneManager.LoadScene(4);
        }
        if (GUI.Button(new Rect(15, 260, 100, 50), "Car Select"))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void ConfirmButton()
    {
        SceneManager.LoadScene(4);
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
            if (gameObject.name == "Track2")
                SceneManager.LoadScene(4);
        }
    }
}
