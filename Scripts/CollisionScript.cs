using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionScript: MonoBehaviour {

    float damage = 0.0f;

    // Use this for initialization
    void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        damage += 10.0f;
    }

    // Update is called once per frame
    void Update () {
        Debug.Log(damage);
		if (damage >= 100.0f)
        {
            Debug.Log("CRASHED CAR");
        }
	}
}
