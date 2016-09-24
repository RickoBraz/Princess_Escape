using UnityEngine;
using System.Collections;

public class Gemas : MonoBehaviour {
    public static Gemas instance;
    public int NGemas = 0;

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
        //Quando for fazer o HUD referenciaremos essa variavel
        //Assim como usaremos esse numero para fazer as minimetas
    }
}
