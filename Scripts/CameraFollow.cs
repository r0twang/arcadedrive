using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    GameObject Player;
    public bool followPlayer = true;
    public Transform target;

	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if (followPlayer == true)
        {
            CamFollowPlayer();
        }
        if (EnterCarScript.isPlayerInAnyCar)
        {
            followPlayer = false;
            transform.position = new Vector3(target.position.x, target.position.y + 3.0f, -10f);
        }
        else followPlayer = true;
	}

    public void SetFollowPlayer(bool val)
    {
        followPlayer = val;
    }

    void CamFollowPlayer()
    {
        Vector3 newPos = new Vector3(Player.transform.position.x, Player.transform.position.y, this.transform.position.z);
        this.transform.position = newPos;
    }
}
