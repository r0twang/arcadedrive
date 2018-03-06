using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Track1Script : MonoBehaviour {

    void OnGUI()
	{
		if(GUI.Button(new Rect(5, 5, 100, 100), "Dashboard"))
		{
            SceneManager.LoadScene(1);
		}
        if (GUI.Button(new Rect(5, 150, 100, 50), "Car Select"))
        {
            SceneManager.LoadScene(0);
        }
        if (GUI.Button(new Rect(5, 250, 100, 50), "Exit"))
        {
            Application.Quit();
        }
    }
	
	// Use this for initialization
	void Start () {
        switch (PlayerPrefs.GetInt("ChosenCar"))
        {
            case 0: Debug.Log("chosen Galion"); break;
            case 1: Debug.Log("chosen Edsel"); break;
            case 2: Debug.Log("chosen Sharky"); break;
            case 3: Debug.Log("chosen ZX100"); break;
            default: Debug.Log("chosen Galion"); break;
        }
    }
	
	// Update is called once per frame
	void Update () {

	}
}
