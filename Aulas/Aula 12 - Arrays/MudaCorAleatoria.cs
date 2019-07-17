using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudaCorAleatoria : MonoBehaviour
{
    [SerializeField]
    private Material[] _materiais;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            var renderer = GetComponent<MeshRenderer>();
            // renderer.material = 

            //int[] numeros = new int[3];
            //numeros[0] = 12;
            //numeros[1] = 322;
            //numeros[2] = 165;

            var numAleatorio = Random.Range(0, 3);
            renderer.material = _materiais[numAleatorio];
        }
    }
}
