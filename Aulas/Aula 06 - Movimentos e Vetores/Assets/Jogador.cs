using UnityEngine;

public class Jogador : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var inputJogador = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        var direcao = inputJogador.normalized;
        var rapidez = 10.0f;
        var velocidade = rapidez * direcao;

        var qtdeMovimento = velocidade * Time.deltaTime;
        transform.Translate(qtdeMovimento);
    }
}
