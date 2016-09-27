using UnityEngine;
using System.Collections;

public class fade3 : MonoBehaviour
{
    public string scene;
    public float time;
    public SpriteRenderer sprite;

    void GoScene()
    {//Muda de Scene
        Application.LoadLevel(scene);

    }

    void Start()
    { // Manipula o alpha
        sprite.color = Color.clear;
        StartCoroutine("FadeOut");
        StartCoroutine("FadeIn");
        Invoke("StartFadeOut", time * 2);
        Invoke("GoScene", time * 3);

    }
    IEnumerator FadeIn()
    {
        while (sprite.color.a < 0.99f)
        {
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a + (Time.deltaTime / 2));

            yield return new WaitForSeconds(Time.deltaTime / 2);

        }

    }

    IEnumerator FadeOut()
    {
        while (sprite.color.a > 0.01f)
        {
            sprite.color = new Color(1f, 1f, 1f, sprite.color.a - (Time.deltaTime / 2));
            yield return new WaitForSeconds(Time.deltaTime / 4);

        }
    }

    void StartFadeOut()
    {
        StartCoroutine("FadeOut");

    }

}
