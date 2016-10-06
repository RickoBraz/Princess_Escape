using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gemas : MonoBehaviour {
    public static Gemas instance;
    public int NGemas = 0;
    public Text texto;

    // Use this for initialization
    void Start () {
        if (instance == null)
        {
            instance = this;
        }

    }
	// Update is called once per frame
    public void Pontuaçao()
    {
        NGemas += 5;
        texto.text = (Mathf.RoundToInt(NGemas)).ToString() + " gold";
        //Quando for fazer o HUD referenciaremos essa variavel
        //Assim como usaremos esse numero para fazer as minimetas
    }
}
