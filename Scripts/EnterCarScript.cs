using System.Collections;
using UnityEngine;

public class EnterCarScript : MonoBehaviour {
    public static bool isPlayerInAnyCar = false;
    public bool isPlayerInThisCar = false;
    public float minEnterDistance = 1.0f;
    public Transform exitPivot;
    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        playerEnterCar();
        if (isPlayerInThisCar == true)
        {
            playerPosWhileInCar();
        }
	}

    public void playerEnterCar()
    {
        if (Vector3.Distance (this.transform.position, player.transform.position) < minEnterDistance && isPlayerInThisCar == false )
        {
            if (Input.GetKeyDown (KeyCode.Quote))
            {
                disablePlayerComponents();
                isPlayerInAnyCar = true;
                isPlayerInThisCar = true;
                player.transform.parent = this.transform;
                this.GetComponent<Car2DController>().enabled = true;
            }
        }
        else if (isPlayerInThisCar == true)
        {
            if (Input.GetKeyDown (KeyCode.Quote))
            {
                enablePlayerComponents();
                isPlayerInAnyCar = false;
                isPlayerInThisCar = false;
                player.transform.parent = player.transform.parent;
                this.GetComponent<Car2DController>().enabled = false;
            }
        }
    }

    void playerPosWhileInCar()
    {
        player.transform.position = this.transform.position;
    }

    public void disablePlayerComponents()
    {
        PlayerMovement pMov = player.GetComponent<PlayerMovement>();
        pMov.enabled = false;
        BoxCollider2D boxCol2d = player.GetComponent<BoxCollider2D>();
        boxCol2d.enabled = false;
        SpriteRenderer spriteRen = player.GetComponent<SpriteRenderer>();
        spriteRen.enabled = false;
    }

    public void enablePlayerComponents()
    {
        PlayerMovement pMov = player.GetComponent<PlayerMovement>();
        pMov.enabled = true;
        BoxCollider2D boxCol2d = player.GetComponent<BoxCollider2D>();
        boxCol2d.enabled = true;
        SpriteRenderer spriteRen = player.GetComponent<SpriteRenderer>();
        spriteRen.enabled = true;
    }
}
