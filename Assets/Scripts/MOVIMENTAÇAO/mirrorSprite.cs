using UnityEngine;
using System.Collections;

public class mirrorSprite : MonoBehaviour {


	void Update ()
    {
        if (gameObject.GetComponent<Tween>().mirror == false){
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (gameObject.GetComponent<Tween>().mirror == true){
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
