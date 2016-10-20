using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<collPlayer>().afectLife();
            GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<RandomPrincess>().Start();
        }
    }
}
