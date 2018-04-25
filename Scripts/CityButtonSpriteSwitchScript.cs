using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityButtonSpriteSwitchScript : MonoBehaviour {

    private MenuAppearScript selectedCityScript;
    public Button button;
    public Sprite notPressedSprite;
    public Sprite pressedSprite;

    void Start()
    {
        selectedCityScript = GetComponent<MenuAppearScript>();
    }

    // Update is called once per frame
    void Update () {
        //PlayerPrefs.GetInt("selectedCity", MenuAppearScript.selectedCityIndex);

        switch (PlayerPrefs.GetInt("selectedCity", MenuAppearScript.selectedCityIndex))
        {
            case 0:
                {
                    button.image.sprite = notPressedSprite;
                    button = GetComponent<Button>();
                    button.image.sprite = pressedSprite;
                }
                break;
        }

    }
}