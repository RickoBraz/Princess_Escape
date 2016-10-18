using UnityEngine;
using System.Collections;

public class Plataforma : MonoBehaviour
{
    public enum TPlataforma { Quebravel, NQuebravel };
    public TPlataforma tipo;
    public GameObject broke;
    // Use this for initialization

    void Start() {
        if (tipo == TPlataforma.Quebravel) {
            GetComponent<SpriteRenderer>().color = new Color (0.5f,0f,0.2f,1f);
        }

    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet" && tipo == TPlataforma.Quebravel) {
            Destroy(this.gameObject);
            Instantiate(broke, (gameObject.transform.position), Quaternion.identity);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Bullet" && tipo == TPlataforma.NQuebravel){ Destroy(other.gameObject); }
    }
}
