﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Rigidbody2D rgbd;

	// Use this for initialization
	void Start () {
        rgbd = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorz = Input.GetAxisRaw("Horizontal");
        float moveVert = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(moveHorz, moveVert);
        rgbd.AddForce(movement * speed);
    }
}
