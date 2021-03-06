﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomPrincess : MonoBehaviour {

    public Animator animator;
    [SerializeField]private int princess = 0;
    private int lastprincess = -1;
    public GameObject balaosfx;
    private int qpower;
    public GameObject slowtime, fastime, newparticle;

    public void Start ()
    {
        princess = Random.Range(0, 6);
        if (lastprincess == princess) {
            Start();
        }
        if (lastprincess != princess) {
            animator.SetInteger("number", princess);
            lastprincess = princess;
        }

    }

    void Update() {
        if (Input.GetAxis("Horizontal") < 0){
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetAxis("Horizontal") > 0){
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PowerUp")
        {
            Instantiate(balaosfx, (gameObject.transform.position), Quaternion.identity);
            animator.Play("New State", -1, float.NegativeInfinity);
            Start();
            qpower = Random.Range(0, 6);
            //if (qpower == 4) Instantiate(slowtime, (gameObject.transform.position), Quaternion.identity);
            //if (qpower == 1) Instantiate(fastime, (gameObject.transform.position), Quaternion.identity);
            Instantiate(newparticle, (gameObject.transform.position), Quaternion.identity); 
            Destroy(other.gameObject);
            collPlayer.instance.Mlife();
        }
    }
 
}
