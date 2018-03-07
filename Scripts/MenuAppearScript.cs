using UnityEngine;
using System.Collections;

public class MenuAppearScript : MonoBehaviour
{
    public GameObject czewaMenuPrefab;
    public GameObject katoMenuPrefab;
    public GameObject krakMenuPrefab;
    public enum Cities { empty, Czewa, Kato, Krak };
    public Cities chosenCity;
    public static Cities baseCity;

    private void Awake()
    {
        czewaMenuPrefab.SetActive(false);
        katoMenuPrefab.SetActive(false);
        krakMenuPrefab.SetActive(false);

        switch (baseCity)
        {
            case Cities.Czewa:
                czewaMenuPrefab.SetActive(true);
                katoMenuPrefab.SetActive(false);
                krakMenuPrefab.SetActive(false);
                break;

            case Cities.Kato:
                czewaMenuPrefab.SetActive(false);
                katoMenuPrefab.SetActive(true);
                krakMenuPrefab.SetActive(false);
                break;

            case Cities.Krak:
                czewaMenuPrefab.SetActive(false);
                katoMenuPrefab.SetActive(false);
                krakMenuPrefab.SetActive(true);
                break;

            default:
                czewaMenuPrefab.SetActive(false);
                katoMenuPrefab.SetActive(false);
                krakMenuPrefab.SetActive(false);
                break;
        }
    }

    private void Update()
    {
        switch (chosenCity)
        {
            case Cities.Czewa:
                czewaMenuPrefab.SetActive(true);
                katoMenuPrefab.SetActive(false);
                krakMenuPrefab.SetActive(false);
                break;

            case Cities.Kato:
                czewaMenuPrefab.SetActive(false);
                katoMenuPrefab.SetActive(true);
                krakMenuPrefab.SetActive(false);
                break;

            case Cities.Krak:
                czewaMenuPrefab.SetActive(false);
                katoMenuPrefab.SetActive(false);
                krakMenuPrefab.SetActive(true);
                break;

            default:
                czewaMenuPrefab.SetActive(false);
                katoMenuPrefab.SetActive(false);
                krakMenuPrefab.SetActive(false);
                break;
        }
    }

    public void OnCzewaCityClick()
    {
        chosenCity = Cities.Czewa;
    }

    public void OnKatoCityClick()
    {
        chosenCity = Cities.Kato;
    }

    public void OnKrakCityClick()
    {
        chosenCity = Cities.Krak;
    }
}