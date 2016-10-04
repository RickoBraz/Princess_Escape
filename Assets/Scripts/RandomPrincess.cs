using UnityEngine;
using System.Collections;

public class RandomPrincess : MonoBehaviour {

    public Animator animator;

	void Start ()
    {

        animator.SetInteger("Player",Random.Range(0, 5));
	}
    void OnCollisionEnter2D(Collision2D other)
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
