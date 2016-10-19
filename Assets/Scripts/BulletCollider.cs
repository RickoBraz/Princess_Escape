using UnityEngine;
using System.Collections;

public class BulletCollider : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "end") Destroy(other.gameObject);
        if (other.gameObject.tag == "Respwan") Destroy(other.gameObject);

    }
}
