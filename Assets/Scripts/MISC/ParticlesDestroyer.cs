using UnityEngine;
using System.Collections;

public class ParticlesDestroyer : MonoBehaviour {

    public float time = 1f;


    void Start()
    {
        Invoke("destroyBullet", time);
    }

    void destroyBullet()
    {
        Destroy(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
        }
        if (other.gameObject.tag == "Respawn")
        {
            Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
        }
        if (other.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(this.gameObject.GetComponent<Collider2D>(), other.gameObject.GetComponent<Collider2D>());
            
        }
    }
}
