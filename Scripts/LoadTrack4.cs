using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTrack4 : MonoBehaviour {

    public void ConfirmButton()
    {
        SceneManager.LoadScene("bielsko");
    }

    public void ConfirmTrackButton()
    {
        SceneManager.LoadScene("track4");
    }

    // Use this for initialization
    void Start()
    {
        PlayerPrefs.GetInt("ChosenCar");
        Debug.Log(PlayerPrefs.GetInt("ChosenCar"));
        EnterCarScript.isPlayerInAnyCar = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (gameObject.name == "track4")
                SceneManager.LoadScene("track4");
        }
    }
}
