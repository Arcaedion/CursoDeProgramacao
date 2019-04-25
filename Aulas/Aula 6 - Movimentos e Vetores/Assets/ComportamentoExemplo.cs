using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoExemplo : MonoBehaviour
{
    private MeshRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _renderer.material.color = Color.red;
        }
    }
}
