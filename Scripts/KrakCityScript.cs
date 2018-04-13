using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KrakCityScript : MonoBehaviour {

    public bool bielskoDestMenuActive = false;
    public bool czewaDestMenuActive = false;
    public bool katoDestMenuActive = false;
    public GameObject bielskoDestMenuPrefab;
    public GameObject czewaDestMenuPrefab;
    public GameObject katoDestMenuPrefab;
    public enum Destinations { Czewa = 0, Kato = 1, Bielsko = 3, empty = 999 };
    public Destinations chosenDestination = Destinations.empty;
    public static int destinationCityIndex;

    const float czewaKrakDist = 310.0f;
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

            case Destinations.Kato:
                katoDestMenuPrefab.SetActive(katoDestMenuActive);
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
        katoDestMenuActive = false;
        bielskoDestMenuPrefab.SetActive(bielskoDestMenuActive);
        czewaDestMenuPrefab.SetActive(czewaDestMenuActive);
        katoDestMenuPrefab.SetActive(katoDestMenuActive);
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

    public void OnKatoCityClick()
    {
        clearCities();
        destinationCityIndex = 1;
        katoDestMenuActive = !katoDestMenuActive;
        katoDestMenuPrefab.SetActive(katoDestMenuActive);
        chosenDestination = Destinations.Kato;
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
