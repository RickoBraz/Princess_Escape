using UnityEngine;
using System.Collections;

public class FadeBlack : MonoBehaviour {

    [Header("Indique a velocidade da ação")]
    public float tempo;
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        goBlack();
    }

    void goBlack()
    {
        sprite.color = Color.black;
        StartCoroutine("anulaBlack");

    }

    IEnumerator anulaBlack()
    {
        while (sprite.color.r < 0.99f && sprite.color.g < 0.99f && sprite.color.b < 0.99f)
        {
            sprite.color = new Color(sprite.color.r + (Time.deltaTime / tempo), sprite.color.g + (Time.deltaTime / tempo), sprite.color.b + (Time.deltaTime / tempo), sprite.color.a);
            yield return new WaitForSeconds(Time.deltaTime / 2);
        }
    }

}