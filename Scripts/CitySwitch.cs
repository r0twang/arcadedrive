using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CitySwitch : MonoBehaviour {

    private List<GameObject> cityList;

    private int selectionIndex = 0;

    // Use this for initialization
    void Start()
    {
        cityList = new List<GameObject>();

        foreach(Transform t in transform)
        {
            cityList.Add(t.gameObject);
            t.gameObject.SetActive(false);
        }

        cityList[selectionIndex].SetActive(true);
    }

    public void Select(int index)
    {
        if (index == selectionIndex)
            return;

        if (index < 0 || index >= cityList.Count)
            return;

        cityList[selectionIndex].SetActive(false);
        selectionIndex = index;
        cityList[selectionIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update () {

	}
}
