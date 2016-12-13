using UnityEngine;
using System.Collections;

public class INTROANIM : MonoBehaviour {

    public GameObject fade;
    public GameObject[] textos;
    int numbero = 0;
    // Use this for initialization
    void Start () {
        Invoke("FADEoutForText", 2.3f);
        Invoke("TextosInit", 2.3f + 1f);
        Invoke("TextosInit", 2.3f + 2.5f);
        Invoke("TextosInit", 2.3f + 4f);
        Invoke("TextosInit", 2.3f + 5f);
        Invoke("TextosInit", 2.3f + 7f);
        Invoke("TextosInit", 2.3f + 8.5f);
        Invoke("cenaseguinte", 2.3f + 14f);
    }

    // Update is called once per frame
    void FADEoutForText () {
        Instantiate(fade);
	}

    void TextosInit()
    {
        Instantiate(textos[numbero]);
        numbero += 1;
    }

    void Update() {
        if (Input.anyKey) cenaseguinte();
    }

    void cenaseguinte() {
        Application.LoadLevel("02 MENU");
    }
}
