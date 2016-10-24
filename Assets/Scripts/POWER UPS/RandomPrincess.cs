using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomPrincess : MonoBehaviour {

    public Animator animator;
    private int princess;

	public void Start ()
    {
        princess = Random.Range(0, 5);
        animator.SetInteger("Number", princess);
        
    }

    void Update() {
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PowerUp")
        {
            animator.Play("Player_default", -1, float.NegativeInfinity);
            Start();

            Destroy(other.gameObject);
            collPlayer.instance.Mlife();
        }
    }
 
}
