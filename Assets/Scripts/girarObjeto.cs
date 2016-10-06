using UnityEngine;
using System.Collections;

public class girarObjeto : MonoBehaviour
    {
    public float velocidade;
    void Update ()
    {
        transform.Rotate(new Vector3(0f, 0f, velocidade) * Time.deltaTime);
    }
}
