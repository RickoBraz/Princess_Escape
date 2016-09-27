using UnityEngine;
using System.Collections;

public class RandomSprite : MonoBehaviour {

    public Sprite[] imagens;
    private int i;
	void Start () {
        i = Random.Range(0, imagens.Length - 1);
        GetComponent<SpriteRenderer>().sprite = imagens[i];
	}

}
