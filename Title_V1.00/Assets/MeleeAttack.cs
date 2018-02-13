using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour {

    public GameObject attack;
    public GameObject player;

    void Update()
    {
        Ray directionOfAttack = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(directionOfAttack)){
            Instantiate(attack, transform.position, transform.rotation);
        }
    }

}
