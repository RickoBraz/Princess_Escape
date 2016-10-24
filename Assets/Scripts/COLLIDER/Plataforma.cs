using UnityEngine;
using System.Collections;

public class Plataforma : MonoBehaviour{

    public enum TPlataforma { Quebravel, NQuebravel };
    [Header("Controle de Plataformas")]
    public TPlataforma tipo;

  [Header("Particula a ser produzida")]
    public GameObject broke;


    void Start() {
      // função de desenvolvimento
       // if (tipo == TPlataforma.Quebravel) GetComponent<SpriteRenderer>().color = new Color (0f,0f,0f,1f);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Bullet" && tipo == TPlataforma.Quebravel) {
            Destroy(this.gameObject);
            Gemas.instance.Pontuaçao();

            // gerar particula
            Instantiate(broke, (gameObject.transform.position), Quaternion.identity);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Bullet" && tipo == TPlataforma.NQuebravel){ Destroy(other.gameObject); }
    }
}
