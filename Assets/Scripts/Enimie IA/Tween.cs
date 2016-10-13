using UnityEngine;
using System.Collections;

public class Tween : MonoBehaviour
{
    //Obs: Posicione o objeto no meio, sabendo que ele vai primeiro pra direita depois para esquerda
    [Header("Diga a velocidade do objeto")]
    public float time = 2;
    [Header("Diga a curva de movimento do objeto")]
    public AnimationCurve curve;
    private float start, end, startTime;
    [Header("Controle de animação")]
    public bool mirror;

    void Start()
    {
        startTime = Time.time;
        start = transform.position.x;
        end = start + time;
    }

    void Update()
    {
        transform.position = new Vector3((end - start) * curve.Evaluate(DeltaTime()) + start, transform.position.y, transform.position.z);
    }

    void FixedUpdate()
    {

        // DeltaTime Bug Fix
        if (DeltaTime() == 1)
        {
            float temp = end;
            end = start;
            start = temp;
            startTime = Time.time;
        }
    }

    float DeltaTime()
    {
        float timeDelta = Time.time - startTime;
        if (timeDelta < time)
        {
            return timeDelta / time;
        }
        else
        {
            mirror = !mirror;
            return 1;
        }
    }
}