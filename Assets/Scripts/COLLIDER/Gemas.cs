using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gemas : MonoBehaviour {
    public static Gemas instance;

    [Header("numero atual coletado")]
    public int NGemas = 0;
    public static int highscore;

    [Header("local de exibição")]
    public Text texto;

    public void SaveScore() {
        PlayerPrefs.SetInt("highscore", NGemas);
    }

    void Start () {
        if (instance == null) instance = this;
        NGemas = highscore;
    }

    public void Pontuaçao(){
        NGemas += 5;
        //Quando for fazer o HUD referenciaremos essa variavel
        texto.text = (Mathf.RoundToInt(NGemas)).ToString() + " gold";
    }
}
