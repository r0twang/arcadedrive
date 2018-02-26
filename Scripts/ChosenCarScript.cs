using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChosenCarScript : MonoBehaviour {

    public GameObject galion;
    public GameObject edsel;
    public GameObject sharky;
    public GameObject zx100;

    bool isCarSpawned = false;

    // Use this for initialization
    void Start () {
        switch (PlayerPrefs.GetInt("ChosenCar"))
        {
            case 0:
            {
                Vector3 pos = transform.position;
                Instantiate(galion, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
                    isCarSpawned = true;
                break;
            }
            case 1:
            {
                Vector3 pos = transform.position;
                Instantiate(edsel, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
                    isCarSpawned = true;
                break;
            }
            case 2:
            {
                Vector3 pos = transform.position;
                Instantiate(sharky, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
                    isCarSpawned = true;
                break;
            }
        case 3:
            {
                Vector3 pos = transform.position;
                Instantiate(zx100, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
                    isCarSpawned = true;
                break;
            }
        default:
            {
                Vector3 pos = transform.position;
                Instantiate(galion, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
                    isCarSpawned = true;
                break;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
