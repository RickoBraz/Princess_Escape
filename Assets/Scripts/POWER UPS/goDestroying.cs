using UnityEngine;
using System.Collections;

public class goDestroying : MonoBehaviour {

    [Header("Qual camada vai ser preservada")]
    public string tag = "Plataform";


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != tag) Destroy(other.gameObject);
    }

}
