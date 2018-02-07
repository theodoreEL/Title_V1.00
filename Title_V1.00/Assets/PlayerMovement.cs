using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Rigidbody2D rgbd;

    // Multiple Characters Batman and Fishman are from the tutorial I found. Will be changed later.
    GameObject computer, flash, chrome;
    int characterselect;

    private void Awake()
    {
        characterselect = 1;
        computer = GameObject.Find("Computer");
        flash = GameObject.Find("Flash");
        chrome = GameObject.Find("Chrome");
    }

    // Use this for initialization
    void Start ()
    {
        rgbd = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float moveHorz = Input.GetAxisRaw("Horizontal");
        float moveVert = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(moveHorz, moveVert);
        rgbd.AddForce(movement * speed);
    }

    // A function to update the characters
    void Update()
    {
        // Increments the character number
        if (Input.GetButtonDown("Jump"))
        {
            if (characterselect == 1)
            {
                characterselect = 2;
            }
            else if (characterselect == 2)
            {
                characterselect = 3;
            }
            else if (characterselect == 3)
            {
                characterselect = 1;
            }
        }
        // Sets the character based on the value of characterselect
        if (characterselect == 1)
        {
            computer.SetActive(true);
            flash.SetActive(false);
            chrome.SetActive(false);
        }
        else if (characterselect == 2)
        {
            computer.SetActive(false);
            flash.SetActive(true);
            chrome.SetActive(false);
        }
        else if (characterselect == 3)
        {
            flash.SetActive(false);
            chrome.SetActive(true);
            computer.SetActive(false);
        }
    }

}
