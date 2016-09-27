using UnityEngine;
using System.Collections;

public class girarObjeto : MonoBehaviour
    {

    void Update ()
    {
        transform.Rotate(new Vector3(0f, 0f, 200f) * Time.deltaTime);
    }
}
