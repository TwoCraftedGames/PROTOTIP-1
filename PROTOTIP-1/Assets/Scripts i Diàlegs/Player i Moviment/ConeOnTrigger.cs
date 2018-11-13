using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeOnTrigger : MonoBehaviour {
    public ZombieAi zombieAi;


    void OnTriggerEnter2D(Collider2D o)
    {

        if (o.gameObject.tag == "Player")
        {
            zombieAi.inViewCone = true;
        }
    }

    void OnTriggerExit2D(Collider2D o)
    {


        if (o.gameObject.tag == "Player")
        {
            zombieAi.inViewCone = false;
        }
    }
}