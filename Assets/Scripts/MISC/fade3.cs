using UnityEngine;
using System.Collections;

public class fade3 : MonoBehaviour
{
    [Header("cena destino")]
    public string scene;

    [Header("Tempo necessário")]
    public float time;

    [Header("Sprite alvo")]
    public SpriteRenderer sprite;

    void GoScene() {
        Application.LoadLevel(scene);
    }

    void Start() {
        sprite.color = Color.clear;
        StartCoroutine("FadeOut");
        StartCoroutine("FadeIn");
        Invoke("StartFadeOut", time * 2);
        Invoke("GoScene", time * 3);
    }

    IEnumerator FadeIn(){
        while (sprite.color.a < 0.99f) {
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a + (Time.deltaTime / 2));
            yield return new WaitForSeconds(Time.deltaTime / 2);
        }
    }

    IEnumerator FadeOut(){
        while (sprite.color.a > 0.01f){
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a - (Time.deltaTime / 2));
            yield return new WaitForSeconds(Time.deltaTime / 4);
        }
    }

    void StartFadeOut(){
        StartCoroutine("FadeOut");
    }
}
