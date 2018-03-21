using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTrack8 : MonoBehaviour {

    public void ConfirmButton()
    {
        SceneManager.LoadScene("krak");
    }

    public void ConfirmTrackButton()
    {
        SceneManager.LoadScene("track8");
    }

    // Use this for initialization
    void Start () {
        EnterCarScript.isPlayerInAnyCar = false;
    }
	
	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches)
		{
			if(gameObject.name == "Track8")
                SceneManager.LoadScene(3);
        }
    }
}