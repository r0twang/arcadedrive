using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CarSelectionScript : MonoBehaviour {

    private List<GameObject> cars;
    private int selectionIndex;

    private GameObject[] carsList;

	// Use this for initialization
	void Start () {

        selectionIndex = PlayerPrefs.GetInt("Chosencar");

        carsList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            carsList[i] = transform.GetChild(i).gameObject;
        }

        foreach (GameObject go in carsList)
        {
            go.SetActive(false);
        }

        if (carsList[selectionIndex])
        {
            carsList[selectionIndex].SetActive(true);
        }
    }

    public void ToggleLeft()
    {
        carsList[selectionIndex].SetActive(false);
        selectionIndex--;

        if (selectionIndex < 0)
        {
            selectionIndex = carsList.Length - 1;
        }
        carsList[selectionIndex].SetActive(true);
        Debug.Log(selectionIndex);
    }

    public void ToggleRight()
    {
        carsList[selectionIndex].SetActive(false);
        selectionIndex++;

        if (selectionIndex >= carsList.Length)
        {
            selectionIndex = 0;
        }
        carsList[selectionIndex].SetActive(true);
        Debug.Log(selectionIndex);
    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("ChosenCar", selectionIndex);
        SceneManager.LoadScene(1);
    }

    //private void Update()
    //{
    //    if (Input.GetButtonDown("Right"))
    //    {
    //        carsList[selectionIndex].SetActive(false);
    //        selectionIndex++;

    //        if (selectionIndex >= carsList.Length)
    //        {
    //            selectionIndex = 0;
    //        }
    //        carsList[selectionIndex].SetActive(true);
    //    }
    //    if (Input.GetButtonDown("Left"))
    //    {
    //        carsList[selectionIndex].SetActive(false);
    //        selectionIndex--;

    //        if (selectionIndex < 0)
    //        {
    //            selectionIndex = carsList.Length - 1;
    //        }
    //        carsList[selectionIndex].SetActive(true);
    //    }
    //    if (Input.GetButtonDown("Submit"))
    //    {
    //        PlayerPrefs.SetInt("ChosenCar", selectionIndex);
    //        SceneManager.LoadScene(1);
    //    }
    //}
}
