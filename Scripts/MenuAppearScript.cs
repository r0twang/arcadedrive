using UnityEngine;
using UnityEngine.UI;
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

    public static int selectedCityIndex;

    private GameObject[] cityList;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        clearCities();
    }

    private void Start()
    {
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
    }

    public void OnCzewaCityClick()
    {
        clearCities();
        selectedCityIndex = 0;
        czewaActive = !czewaActive;
        czewaMenuPrefab.SetActive(czewaActive);
        chosenCity = Cities.Czewa;
        PlayerPrefs.SetInt("selectedCity", selectedCityIndex);
        Debug.Log("Selected city: " + selectedCityIndex);
    }

    public void OnKatoCityClick()
    {
        clearCities();
        selectedCityIndex = 1;
        katoActive = !katoActive;
        katoMenuPrefab.SetActive(katoActive);
        chosenCity = Cities.Kato;
        PlayerPrefs.SetInt("selectedCity", selectedCityIndex);
        Debug.Log("Selected city: " + selectedCityIndex);
    }

    public void OnKrakCityClick()
    {
        clearCities();
        selectedCityIndex = 2;
        krakActive = !krakActive;
        krakMenuPrefab.SetActive(krakActive);
        chosenCity = Cities.Krak;
        PlayerPrefs.SetInt("selectedCity", selectedCityIndex);
        Debug.Log("Selected city: " + selectedCityIndex);
    }

    public void OnBielskoCityClick()
    {
        clearCities();
        selectedCityIndex = 3;
        bielskoActive = !bielskoActive;
        bielskoMenuPrefab.SetActive(bielskoActive);
        chosenCity = Cities.Bielsko;
        PlayerPrefs.SetInt("selectedCity", selectedCityIndex);
        Debug.Log("Selected city: " + selectedCityIndex);
    }

}