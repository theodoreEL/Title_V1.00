using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour {

    public float moveSpeed;
    private float horizMoveVelocity;
    private float vertMoveVelocity;
    private Rigidbody2D playerRigidBody;
    //public Transform firePosition;
    public BulletController bullet;
    public Transform bulletProj;
    private float shootHoriz;
    private float shootVert;
    //Vector2 prevDir = Vector2.right;

    // Use this for initialization
    void Start () {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
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
        if (shootHoriz != 0 || shootVert != 0)
            Instantiate(bullet, transform.position, transform.rotation);

        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            firePosition.Rotate(Vector3.up);
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            firePosition.Translate(-firePosition.position.x, -firePosition.position.y, 0);
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            firePosition.Translate(-2*firePosition.position.x, 0, 0);
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            firePosition.Translate(0, firePosition.position.y, 0);
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }

        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            firePosition.Translate(-2*firePosition.position.x, firePosition.position.y, 0);
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }

        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            firePosition.Translate(0, -firePosition.position.y, 0);
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            firePosition.Translate(-2*firePosition.position.x, -firePosition.position.y, 0);
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }

   void Update()
    {
        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //if player stoped moving, we want to save last moving direction  (it is short form of IF statement);
        prevDir = (movement_vector.Equals(Vector2.zero)) ? prevDir : movement_vector;
        rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime);
        //instatiate fireBall
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //create tmp variable to call its function
            FireBall tmp = (FireBall)Instantiate(fireBall, transform.position, Quaternion.identity);
            //send normalized vector to our created fireball
            tmp.Dir(prevDir.normalized);
        }
    }*/
    }
}


