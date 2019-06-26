using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionaVela : MonoBehaviour
{
    [SerializeField]
    private float _rapidezRotacao = 10.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Rotaciona(0, 1, 0);
        }else if (Input.GetKey(KeyCode.Q))
        {
            Rotaciona(0, -1, 0);
        }
    }

    public void Rotaciona(float x, float y, float z)
    {
        var inputJogadorRotacao = new Vector3(x, y, z);
        var direcao = inputJogadorRotacao.normalized;
        var velocidade = _rapidezRotacao * direcao;
        var qtdeMovimento = velocidade * Time.deltaTime;

    }


}
