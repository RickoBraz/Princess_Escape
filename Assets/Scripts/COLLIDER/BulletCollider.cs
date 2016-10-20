using UnityEngine;
using System.Collections;

public class BulletCollider : MonoBehaviour {

    void Start() {
        Invoke("destroyBullet", 1f);
    }

    void destroyBullet() {
        Destroy(this.gameObject);
    }


    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "end") Destroy(this.gameObject);
        if (other.gameObject.tag == "Respawn")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }

    }
}
