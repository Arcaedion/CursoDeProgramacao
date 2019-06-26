using UnityEngine;

public class Jogador : MonoBehaviour
{
    [SerializeField]
    private float _rapidez = 10.0f;
    [SerializeField]
    private float _rapidezRotacao = 10.0f;

    void Update()
    {
        Movimenta(0, 0, Input.GetAxisRaw("Vertical"));
        Rotaciona(0, Input.GetAxisRaw("Horizontal"), 0);
    }

    public void Movimenta(float x, float y, float z)
    {
        var inputJogador = new Vector3(x, y, z);
        var direcao = inputJogador.normalized;
        var velocidade = _rapidez * direcao;

        var qtdeMovimento = velocidade * Time.deltaTime;
        transform.Translate(qtdeMovimento);

    }

    public void Rotaciona(float x, float y, float z)
    {
        var inputJogadorRotacao = new Vector3(x, y, z);
        var direcao = inputJogadorRotacao.normalized;
        var velocidade = _rapidezRotacao * direcao;
        var qtdeMovimento = velocidade * Time.deltaTime;

        transform.Rotate(qtdeMovimento);
    }


}
