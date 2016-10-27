using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gemas : MonoBehaviour {
    public static Gemas instance;

    [Header("Numero atual coletado")]
    public int NGemas;
    public static int highscore;

    [Header("Local de exibição")]
    public Text texto;

    void Start () {
        if (instance == null) instance = this;
        NGemas = PlayerPrefs.GetInt("highscore");
    }

    public void Pontuaçao(){
        NGemas += 1;
        //Quando for fazer o HUD referenciaremos essa variavel
        texto.text = (Mathf.RoundToInt(NGemas)).ToString() + " gold";
    }

    public void SaveHigh()
    {
        PlayerPrefs.SetInt("highscore", NGemas);
    }

}
