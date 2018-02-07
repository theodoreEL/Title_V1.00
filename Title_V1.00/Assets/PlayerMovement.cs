using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Rigidbody2D rgbd;

    // This creates the multiple characters. The 3 we decided to start with are the artist, boombox, and segway squid
    GameObject artist, boomBox, segway, eighty, snek;
    int characterselect;
    int cooldown;

    private void Awake()
    {
        cooldown = 0;
        characterselect = 1;
        artist = GameObject.Find("artistCharacter"); // The artist character
        boomBox = GameObject.Find("boomBoxCharacter"); // The boombox character
        segway = GameObject.Find("segwaySquid"); // The segway character
        eighty = GameObject.Find("eightysGuy"); // The eighty's guy character
        snek = GameObject.Find("snakeGunner"); // The snake with a gun
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
        // A cooldown tier for swithcing characters.
        if (cooldown > 0)
        {
            cooldown--;
        }

        // Increments the character number using the Jump button which is the Space Bar
        if (Input.GetButtonDown("Jump"))
        {
            if (characterselect == 1 && cooldown < 1)
            {
                characterselect = 2;
                cooldown = 300;
            }
            else if (characterselect == 2 && cooldown < 1)
            {
                characterselect = 3;
                cooldown = 300;
            }
            else if (characterselect == 3 && cooldown < 1)
            {
                characterselect = 4;
                cooldown = 300;
            }
            else if (characterselect == 4 && cooldown < 1)
            {
                characterselect = 5;
                cooldown = 300;
            }
            else if (characterselect == 5 && cooldown < 1)
            {
                characterselect = 1;
                cooldown = 300;
            }

        }
        // Sets the character based on the value of characterselect
        if (characterselect == 1)
        {
            artist.SetActive(true);
            snek.SetActive(false);
            segway.SetActive(false);
            eighty.SetActive(false);
            boomBox.SetActive(false);
        }
        else if (characterselect == 2)
        {
            artist.SetActive(false);
            boomBox.SetActive(true);
            snek.SetActive(false);
            eighty.SetActive(false);
            segway.SetActive(false);

        }
        else if (characterselect == 3)
        {
            boomBox.SetActive(false);
            segway.SetActive(true);
            artist.SetActive(false);
            eighty.SetActive(false);
            snek.SetActive(false);
        }
        else if (characterselect == 4)
        {
            segway.SetActive(false);
            eighty.SetActive(true);
            artist.SetActive(false);
            snek.SetActive(false);
            boomBox.SetActive(false);
        }
        else if (characterselect == 5)
        {
            eighty.SetActive(false);
            snek.SetActive(true);
            artist.SetActive(false);
            boomBox.SetActive(false);
            segway.SetActive(false);
        }
    }

}
