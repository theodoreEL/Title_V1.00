﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayer : MonoBehaviour {

    public GameObject thePlayer;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == thePlayer)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject == thePlayer)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
