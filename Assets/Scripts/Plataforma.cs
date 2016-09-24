using UnityEngine;
using System.Collections;

public class Plataforma : MonoBehaviour
{
    public enum TPlataforma { Quebravel, NQuebravel };
    public TPlataforma tipo;
    // Use this for initialization

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet" && tipo == TPlataforma.Quebravel) { Destroy(this.gameObject); Destroy(other.gameObject); }
        if (other.gameObject.tag == "Bullet" && tipo == TPlataforma.NQuebravel){ Destroy(other.gameObject); }
    }
}
