using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
