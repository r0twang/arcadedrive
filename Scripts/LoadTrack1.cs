using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTrack1 : MonoBehaviour {

	void OnGUI()
	{
		if (GUI.Button(new Rect(15, 20, 100, 50), "Track1"))
		{
            SceneManager.LoadScene(2);
        }
        if (GUI.Button(new Rect(15, 180, 100, 50), "Car Select"))
        {
            SceneManager.LoadScene(0);
        }
    }

    // Use this for initialization
    void Start () {
        PlayerPrefs.GetInt("ChosenCar");
        Debug.Log(PlayerPrefs.GetInt("ChosenCar"));
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
