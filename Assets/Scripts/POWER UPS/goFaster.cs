using UnityEngine;
using System.Collections;

public class goFaster : MonoBehaviour {

    [Header("Tempo de duração efeito")]
    public float tempo_total;
    private float valorAtual;
    private float tempo_limite;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 2f;
        tempo_limite = tempo_total;
        tempo_total = 0;
    }

    void Update()
    {
        Debug.Log(valorAtual);

        valorAtual += Time.deltaTime / 2;
        if (valorAtual > tempo_limite) AnularEfeito();
    }

    void AnularEfeito() {
        Time.timeScale = 1f;
        Destroy(this.gameObject);
    }
}

