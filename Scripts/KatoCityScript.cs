using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KatoCityScript : MonoBehaviour {

    public bool bielskoDestMenuActive = false;
    public bool czewaDestMenuActive = false;
    public bool krakDestMenuActive = false;
    public GameObject bielskoDestMenuPrefab;
    public GameObject czewaDestMenuPrefab;
    public GameObject krakDestMenuPrefab;
    public enum Destinations { Czewa = 0, Krak = 2, Bielsko = 3, empty = 999 };
    public Destinations chosenDestination = Destinations.empty;
    public static int destinationCityIndex;

    const float czewaKatoDist = 210.0f;
    const float katoKrakDist = 130.0f;
    const float katoBielskoDist = 110.0f;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        clearCities();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (chosenDestination)
        {
            case Destinations.Czewa:
                czewaDestMenuPrefab.SetActive(czewaDestMenuActive);
                break;

            case Destinations.Krak:
                krakDestMenuPrefab.SetActive(krakDestMenuActive);
                break;

            case Destinations.Bielsko:
                bielskoDestMenuPrefab.SetActive(bielskoDestMenuActive);
                break;

            case Destinations.empty:
            default:
                clearCities();
                break;
        }
    }

    public void clearCities()
    {
        bielskoDestMenuActive = false;
        czewaDestMenuActive = false;
        krakDestMenuActive = false;
        bielskoDestMenuPrefab.SetActive(bielskoDestMenuActive);
        czewaDestMenuPrefab.SetActive(czewaDestMenuActive);
        krakDestMenuPrefab.SetActive(krakDestMenuActive);
    }

    public void OnEmptyClick()
    {
        clearCities();
        chosenDestination = Destinations.empty;
    }

    public void OnCzewaCityClick()
    {
        clearCities();
        destinationCityIndex = 0;
        czewaDestMenuActive = !czewaDestMenuActive;
        czewaDestMenuPrefab.SetActive(czewaDestMenuActive);
        chosenDestination = Destinations.Czewa;
        PlayerPrefs.SetInt("selectedDestination", destinationCityIndex);
    }

    public void OnKrakCityClick()
    {
        clearCities();
        destinationCityIndex = 2;
        krakDestMenuActive = !krakDestMenuActive;
        krakDestMenuPrefab.SetActive(krakDestMenuActive);
        chosenDestination = Destinations.Krak;
        PlayerPrefs.SetInt("selectedDestination", destinationCityIndex);
    }

    public void OnBielskoCityClick()
    {
        clearCities();
        destinationCityIndex = 3;
        bielskoDestMenuActive = !bielskoDestMenuActive;
        bielskoDestMenuPrefab.SetActive(bielskoDestMenuActive);
        chosenDestination = Destinations.Bielsko;
        PlayerPrefs.SetInt("selectedDestination", destinationCityIndex);
    }
}
