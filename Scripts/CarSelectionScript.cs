using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CarSelectionScript : MonoBehaviour {

    private int selectionIndex;

    private GameObject[] carsList;
    private MenuAppearScript activeCityScript;

	// Use this for initialization
	void Start () {

        activeCityScript = GetComponent<MenuAppearScript>();

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
        PlayerPrefs.GetInt("selectedCity", MenuAppearScript.selectedCityIndex);
        switch (MenuAppearScript.selectedCityIndex)
        {
            case 0: SceneManager.LoadScene("czewa"); break;
            case 1: SceneManager.LoadScene("kato"); break;
            case 2: SceneManager.LoadScene("krak"); break;
            case 3: SceneManager.LoadScene("bielsko"); break;
            case 999: SceneManager.LoadScene("czewa"); break;
        }
    }
}
