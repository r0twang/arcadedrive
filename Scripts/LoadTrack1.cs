using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTrack1 : MonoBehaviour {
    void OnGUI()
	{
        if (GUI.Button(new Rect(15, 20, 100, 50), "Dashboard"))
		{
            SceneManager.LoadScene(1);
        }
        if (GUI.Button(new Rect(15, 250, 100, 50), "Exit"))
        {
            Application.Quit();
        }
    }

    public void ConfirmButton()
    {
        SceneManager.LoadScene("kato");
    }

    public void ConfirmTrackButton()
    {
        SceneManager.LoadScene("track1");
    }

    // Use this for initialization
    void Start () {
        PlayerPrefs.GetInt("ChosenCar");
        Debug.Log(PlayerPrefs.GetInt("ChosenCar"));
        EnterCarScript.isPlayerInAnyCar = false;
    }

    // Update is called once per frame
    void Update () {
		foreach(Touch touch in Input.touches)
		{
			if(gameObject.name == "Track1")
                SceneManager.LoadScene(2);
        }
    }
}
