using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelectionScript : MonoBehaviour {

    private List<GameObject> cars;
    private int selectionIndex = 0;

	// Use this for initialization
	void Start () {
        cars = new List<GameObject>();

        foreach (Transform t in transform)
        {
            cars.Add(t.gameObject);
            t.gameObject.SetActive(false);
        }
        cars[selectionIndex].SetActive(true);
	}

    // Update is called once per frame
    private void Update()
    {

    }

    public void Select(int index)
    {
        if (index == selectionIndex)
        {
            return;
        }
        if (index < 0 || index >= cars.Count)
        {
            return;
        }
        cars[selectionIndex].SetActive(false);
        selectionIndex = index;
        cars[selectionIndex].SetActive(true);
    }

    //private void OnGUI()
    //{
    //    if (GUI.Button(new Rect(5, 5, 100, 100), "Dashboard"))
    //    {
    //        PlayerPrefs.SetInt("ChosenCar", selectionIndex);
    //        Application.LoadLevel(0);
    //    }
    //}
}
