using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartellTrigger : MonoBehaviour {
    //private bool CartellTrigger = false;

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //CartellTrigger = true;
        anim.SetTrigger("CartellTrigger");
        Debug.Log("CartellTrigger");
    }

}
