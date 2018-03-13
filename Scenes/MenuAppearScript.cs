using UnityEngine;
using System.Collections;

public class MenuAppearScript : MonoBehaviour
{
    public bool czewaActive = false;
    public bool katoActive = false;
    public bool krakActive = false;
    public GameObject czewaMenuPrefab;
    public GameObject katoMenuPrefab;
    public GameObject krakMenuPrefab;
    public GameObject[] cityMenus;
    public enum Cities { empty, Czewa, Kato, Krak };
    public Cities chosenCity;

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

            case Cities.empty:
            default:
                clearCities();
                break;
        }
    }

    public void clearCities()
    {
        czewaActive = false;
        katoActive = false;
        krakActive = false;
        czewaMenuPrefab.SetActive(czewaActive);
        katoMenuPrefab.SetActive(katoActive);
        krakMenuPrefab.SetActive(krakActive);
    }

    public void OnEmptyClick()
    {
        clearCities();
        chosenCity = Cities.empty;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("");
    }

    public void OnCzewaCityClick()
    {
        clearCities();
        czewaActive = !czewaActive;
        czewaMenuPrefab.SetActive(czewaActive);
        chosenCity = Cities.Czewa;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("");
    }

    public void OnKatoCityClick()
    {
        clearCities();
        katoActive = !katoActive;
        katoMenuPrefab.SetActive(katoActive);
        chosenCity = Cities.Kato;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("");
    }

    public void OnKrakCityClick()
    {
        clearCities();
        krakActive = !krakActive;
        krakMenuPrefab.SetActive(krakActive);
        chosenCity = Cities.Krak;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("");
    }
}