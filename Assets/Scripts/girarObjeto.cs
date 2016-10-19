using UnityEngine;
using System.Collections;

public class girarObjeto : MonoBehaviour
    {
    public float velocidade;
    public bool girar = false;

    void FixedUpdate ()
    {
        if (girar == true) transform.Rotate(new Vector3(0f, 0f, velocidade) * Time.deltaTime);
        if (girar == false) transform.Rotate(new Vector3(0f, 0f, 0f));

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Plataforma") girar = false;
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Plataforma") girar = true;
    }
}
