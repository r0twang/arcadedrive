using UnityEngine;
using System.Collections;

public class MenuAppearScript : MonoBehaviour
{
    public bool czewaActive = false;
    public bool katoActive = false;
    public bool krakActive = false;
    public bool bielskoActive = false;
    public GameObject czewaMenuPrefab;
    public GameObject katoMenuPrefab;
    public GameObject krakMenuPrefab;
    public GameObject bielskoMenuPrefab;
    public enum Cities { empty, Czewa, Kato, Krak, Bielsko };
    public Cities chosenCity = Cities.empty;
    public int selectedCityIndex;

    private void Awake()
    {
        Debug.Log(selectedCityIndex);
        clearCities();
    }

    private void Update()
    {
        switch (chosenCity)
        {
            case Cities.Czewa:
                czewaMenuPrefab.SetActive(czewaActive);
                break;

            case Cities.Kato:
                katoMenuPrefab.SetActive(katoActive);
                break;

            case Cities.Krak:
                krakMenuPrefab.SetActive(krakActive);
                break;

            case Cities.Bielsko:
                bielskoMenuPrefab.SetActive(bielskoActive);
                break;

            case Cities.empty:
            default:
                clearCities();
                break;
        }
    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("selectedCity", selectedCityIndex);
        Debug.Log(selectedCityIndex);
    }

    public void clearCities()
    {
        czewaActive = false;
        katoActive = false;
        krakActive = false;
        bielskoActive = false;
        czewaMenuPrefab.SetActive(czewaActive);
        katoMenuPrefab.SetActive(katoActive);
        krakMenuPrefab.SetActive(krakActive);
        bielskoMenuPrefab.SetActive(bielskoActive);
    }

    public void OnEmptyClick()
    {
        clearCities();
        chosenCity = Cities.empty;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("BIELSKO :" + bielskoActive);
        Debug.Log("");
    }

    public void OnCzewaCityClick()
    {
        clearCities();
        selectedCityIndex = 1;
        czewaActive = !czewaActive;
        czewaMenuPrefab.SetActive(czewaActive);
        chosenCity = Cities.Czewa;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("BIELSKO :" + bielskoActive);
        Debug.Log("Selected city: " + selectedCityIndex);
        Debug.Log("");
    }

    public void OnKatoCityClick()
    {
        clearCities();
        selectedCityIndex = 2;
        katoActive = !katoActive;
        katoMenuPrefab.SetActive(katoActive);
        chosenCity = Cities.Kato;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("BIELSKO :" + bielskoActive);
        Debug.Log("Selected city: " + selectedCityIndex);
        Debug.Log("");
    }

    public void OnKrakCityClick()
    {
        clearCities();
        selectedCityIndex = 3;
        krakActive = !krakActive;
        krakMenuPrefab.SetActive(krakActive);
        chosenCity = Cities.Krak;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("BIELSKO :" + bielskoActive);
        Debug.Log("Selected city: " + selectedCityIndex);
        Debug.Log("");
    }

    public void OnBielskoCityClick()
    {
        clearCities();
        selectedCityIndex = 4;
        bielskoActive = !bielskoActive;
        bielskoMenuPrefab.SetActive(bielskoActive);
        chosenCity = Cities.Bielsko;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("BIELSKO :" + bielskoActive);
        Debug.Log("Selected city: " + selectedCityIndex);
        Debug.Log("");
    }

}