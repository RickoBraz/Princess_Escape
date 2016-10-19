using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gemas : MonoBehaviour {
    public static Gemas instance;

    [Header("numero atual coletado")]
    public int NGemas = 0;

    [Header("local de exibição")]
    public Text texto;

    void Start () {
        if (instance == null) instance = this;
    }

    public void Pontuaçao(){
        NGemas += 5;
        //Quando for fazer o HUD referenciaremos essa variavel
        texto.text = (Mathf.RoundToInt(NGemas)).ToString() + " gold";
    }
}
