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
                czewaMenuPrefab.SetActive(false);
                katoMenuPrefab.SetActive(false);
                krakMenuPrefab.SetActive(false);
                break;
        }
    }

    public void OnEmptyClick()
    {
        czewaActive = false;
        katoActive = false;
        krakActive = false;
        czewaMenuPrefab.SetActive(czewaActive);
        katoMenuPrefab.SetActive(katoActive);
        krakMenuPrefab.SetActive(krakActive);
        chosenCity = Cities.Czewa;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("");
    }

    public void OnCzewaCityClick()
    {
        czewaActive = false;
        katoActive = false;
        krakActive = false;
        czewaActive = !czewaActive;
        czewaMenuPrefab.SetActive(czewaActive);
        katoMenuPrefab.SetActive(katoActive);
        krakMenuPrefab.SetActive(krakActive);
        chosenCity = Cities.Czewa;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("");
    }

    public void OnKatoCityClick()
    {
        czewaActive = false;
        katoActive = false;
        krakActive = false;
        katoActive = !katoActive;
        katoMenuPrefab.SetActive(katoActive);
        czewaMenuPrefab.SetActive(czewaActive);
        krakMenuPrefab.SetActive(krakActive);
        chosenCity = Cities.Kato;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("");
    }

    public void OnKrakCityClick()
    {
        czewaActive = false;
        katoActive = false;
        krakActive = false;
        krakActive = !krakActive;
        czewaMenuPrefab.SetActive(czewaActive);
        katoMenuPrefab.SetActive(katoActive);
        krakMenuPrefab.SetActive(krakActive);
        chosenCity = Cities.Krak;
        Debug.Log("CZEWA: " + czewaActive);
        Debug.Log("KATO :" + katoActive);
        Debug.Log("KRAK :" + krakActive);
        Debug.Log("");
    }
}