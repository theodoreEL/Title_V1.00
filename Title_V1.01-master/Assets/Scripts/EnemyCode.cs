using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour {

    public float range;
    public Transform Player;
    public float speed;
    public float knockback;
    public float knockbackLength;
    [HideInInspector]
    public Vector3 hitLocation;
    private Rigidbody2D enemyRB;
    private Vector2 referenceHit;
    private Vector3 currVelocity;

    // Use this for initialization
    void Start () {
        enemyRB = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        currVelocity = enemyRB.velocity;
		if(Vector2.Distance(Player.position, transform.position) <= range)
        {
            //transform.Translate(Vector2.MoveTowards(transform.position, -Player.position, 0) * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, Player.position, step);
        }

        if (hitLocation == Vector3.zero)
        {
            Invoke("PreviousMovement", .4f);
        }
        else
        {
            referenceHit = hitLocation - transform.position;
            enemyRB.velocity = new Vector3(referenceHit.x / Mathf.Abs(referenceHit.x) * (-knockback), referenceHit.y / Mathf.Abs(referenceHit.x) * (-knockback));
            hitLocation = Vector3.zero;
        }
	}

    void PreviousMovement()
    {
        enemyRB.velocity = currVelocity;
    }
}
