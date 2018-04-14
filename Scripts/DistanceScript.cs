using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DistanceScript : MonoBehaviour {

    private MenuAppearScript destinationCityScript;
    private Vector3 previousPosition;
    float sumDistance = 0.0f;
    const float czewaKatoDist = 210.0f;
    const float czewaKrakDist = 310.0f;
    const float katoKrakDist = 130.0f;
    const float katoBielskoDist = 110.0f;
    const float krakBielskoDist = 120.0f;

    // Use this for initialization
    void Start () {
        previousPosition = transform.position;
        destinationCityScript = GetComponent<MenuAppearScript>();
    }

    void DistanceCalculation ()
    {
        float distance = Vector3.Distance(previousPosition, transform.position);
        sumDistance += distance;
        previousPosition = transform.position;

        PlayerPrefs.GetInt("selectedCity", MenuAppearScript.selectedCityIndex);
        switch (MenuAppearScript.selectedCityIndex)
        {
            case 0:
                {
                    PlayerPrefs.GetInt("selectedDestination", CzewaCityScript.destinationCityIndex);
                    switch (CzewaCityScript.destinationCityIndex)
                    {
                        case 1:
                            {
                                if (transform.position.y >= czewaKatoDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 1;
                                    SceneManager.LoadScene("kato");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (transform.position.y >= czewaKrakDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 2;
                                    SceneManager.LoadScene("krak");
                                }
                                break;
                            }
                    }
                    break;
                }
            case 1:
                {
                    PlayerPrefs.GetInt("selectedDestination", KatoCityScript.destinationCityIndex);
                    switch (KatoCityScript.destinationCityIndex)
                    {
                        case 0:
                            {
                                if (transform.position.y >= czewaKatoDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 0;
                                    SceneManager.LoadScene("czewa");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (transform.position.y >= katoKrakDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 2;
                                    SceneManager.LoadScene("krak");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (transform.position.y >= katoBielskoDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 3;
                                    SceneManager.LoadScene("bielsko");
                                }
                                break;
                            }
                    }
                    break;
                }
            case 2:
                {
                    PlayerPrefs.GetInt("selectedDestination", KrakCityScript.destinationCityIndex);
                    switch (KrakCityScript.destinationCityIndex)
                    {
                        case 0:
                            {
                                if (transform.position.y >= czewaKrakDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 0;
                                    SceneManager.LoadScene("czewa");
                                }
                                break;
                            }
                        case 1:
                            {
                                if (transform.position.y >= katoKrakDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 1;
                                    SceneManager.LoadScene("kato");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (transform.position.y >= krakBielskoDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 3;
                                    SceneManager.LoadScene("bielsko");
                                }
                                break;
                            }
                    }
                    break;
                }
            case 3:
                {
                    PlayerPrefs.GetInt("selectedDestination", BielskoCityScript.destinationCityIndex);
                    switch (BielskoCityScript.destinationCityIndex)
                    {
                        case 1:
                            {
                                if (transform.position.y >= katoBielskoDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 1;
                                    SceneManager.LoadScene("kato");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (transform.position.y >= krakBielskoDist)
                                {
                                    EnterCarScript.isPlayerInAnyCar = false;
                                    MenuAppearScript.selectedCityIndex = 2;
                                    SceneManager.LoadScene("krak");
                                }
                                break;
                            }
                    }
                    break;
                }
                //{
                //    if (transform.position.y >= krakBielskoDist)
                //    {
                //        EnterCarScript.isPlayerInAnyCar = false;
                //        SceneManager.LoadScene("bielsko");
                //    }
                //    break;
                //}
        }
    }

    void OnGUI()
    {
        GUIStyle boldFont = new GUIStyle();
        boldFont.richText = true;
        boldFont.fontStyle = FontStyle.Bold;

        GUI.contentColor = Color.red;
        GUILayout.Label("<size=20><color=red>Driven distance: " + transform.position.y + " km</color></size>", boldFont);
    }

    // Update is called once per frame
    void Update () {
        DistanceCalculation();
    }
}
