using UnityEngine;
using System.Collections;

public class FadeRed : MonoBehaviour {
    public static FadeRed instance;

    [Header("Indique a velocidade da ação")]
    public float tempo;
    private SpriteRenderer sprite;
    private GameObject player;

    void Start() {
        if (instance == null) instance = this;

    }

   public void InvokeRed () {
        player = GameObject.FindGameObjectWithTag("Player");
        sprite = player.GetComponent<SpriteRenderer>();
        goRed();
    }

    void goRed () {
        sprite.color = Color.red;
        StartCoroutine("anulaRed");

    }

    IEnumerator anulaRed() {
        while (sprite.color.g < 0.99f && sprite.color.b < 0.99f)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g + (Time.deltaTime / tempo), sprite.color.b + (Time.deltaTime / tempo), sprite.color.a);
            yield return new WaitForSeconds(Time.deltaTime / 2);
        }
    }

}
