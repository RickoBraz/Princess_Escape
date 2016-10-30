using UnityEngine;
using System.Collections;

public class goSlower : MonoBehaviour {

    [Header("Tempo de duração efeito")]
    public float tempo_total;
    private float valorAtual;
    private float tempo_limite;

    // Use this for initialization
    void Start()
    {
        Time.timeScale =0.5f;
        tempo_limite = tempo_total;
        tempo_total = 0;
    }

    void Update()
    {
        valorAtual += Time.deltaTime * 2;
        Debug.Log(valorAtual);
        if (valorAtual > tempo_limite) AnularEfeito();
    }

    void AnularEfeito()
    {
        Time.timeScale = 1f;
        Destroy(this.gameObject);
    }
}