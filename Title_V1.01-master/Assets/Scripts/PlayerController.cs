using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour {

    public float moveSpeed;
    private bool wait;
    private float horizMoveVelocity;
    private float vertMoveVelocity;
    private Rigidbody2D playerRigidBody;
    //public Transform firePosition;
    public BulletController bullet;
    public Transform bulletProj;
    private float shootHoriz;
    private float shootVert;
    private float offset = 1.15f;
    private Vector3 shootPos;
    //Vector2 prevDir = Vector2.right;

    // Use this for initialization
    void Start () {
        wait = false;
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        //Movement: sets moveVelocity of horizontal and vertical movement to 0 each update, unless WASD keys are pressed, then sets them to movespeed
        //and makes playerRigidbody velocity equal to velocity given by specific key pressed

        horizMoveVelocity = 0f;
        vertMoveVelocity = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            horizMoveVelocity = moveSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            horizMoveVelocity = -moveSpeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            vertMoveVelocity = moveSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vertMoveVelocity = -moveSpeed;
        }

        playerRigidBody.velocity = new Vector2(horizMoveVelocity, vertMoveVelocity);

        shootHoriz = Input.GetAxisRaw("FireHoriz");
        shootVert = Input.GetAxisRaw("FireVert");
        bullet.direction = new Vector2(shootHoriz, shootVert);
        shootPos = new Vector3(transform.position.x + offset * shootHoriz, transform.position.y + offset * shootVert, 0);
        if ((shootHoriz != 0 || shootVert != 0) && !wait)
        {
            wait = true;
            Instantiate(bullet, shootPos, transform.rotation);
            Invoke("ShotBullet", .1f);

        }
    }

    void ShotBullet()
    {
        wait = false;
    }
}


