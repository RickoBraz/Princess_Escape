﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomPrincess : MonoBehaviour {

    public Animator animator;
    public Image sprite;
    private int princess;
    public Sprite[] bustos;

	public void Start ()
    {
        princess = Random.Range(0, 5);
        sprite.sprite = bustos[princess];
        animator.SetInteger("Player", princess);
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PowerUp")
        {
            Start();
            animator.Play("Player_default", -1, float.NegativeInfinity);
            Destroy(other.gameObject);
            Movimento.instance.Mlife();
        }
    }
 
}