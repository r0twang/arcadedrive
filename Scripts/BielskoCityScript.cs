using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BielskoCityScript : MonoBehaviour {

    public bool katoDestMenuActive = false;
    public bool krakDestMenuActive = false;
    public GameObject katoDestMenuPrefab;
    public GameObject krakDestMenuPrefab;
    public enum Destinations { Kato = 1, Krak = 2, empty = 999 };
    public Destinations chosenDestination = Destinations.empty;
    public static int destinationCityIndex;

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
    void Update()
    {
        switch (chosenDestination)
        {
            case Destinations.Kato:
                katoDestMenuPrefab.SetActive(katoDestMenuActive);
                break;

            case Destinations.Krak:
                krakDestMenuPrefab.SetActive(krakDestMenuActive);
                break;

            case Destinations.empty:
            default:
                clearCities();
                break;
        }
    }

    public void clearCities()
    {
        krakDestMenuActive = false;
        katoDestMenuActive = false;
        krakDestMenuPrefab.SetActive(krakDestMenuActive);
        katoDestMenuPrefab.SetActive(katoDestMenuActive);
    }

    public void OnEmptyClick()
    {
        clearCities();
        chosenDestination = Destinations.empty;
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

    public void OnKrakCityClick()
    {
        clearCities();
        destinationCityIndex = 2;
        krakDestMenuActive = !krakDestMenuActive;
        krakDestMenuPrefab.SetActive(krakDestMenuActive);
        chosenDestination = Destinations.Krak;
        PlayerPrefs.SetInt("selectedDestination", destinationCityIndex);
    }
}
