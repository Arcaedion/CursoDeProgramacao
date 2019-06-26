using UnityEngine;

public class Jogador : MonoBehaviour
{
    [SerializeField]
    private float _rapidez = 10.0f;

    void Update()
    {
        Movimenta(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    public void Movimenta(float x, float y, float z)
    {
        var inputJogador = new Vector3(x, y, z);
        var direcao = inputJogador.normalized;
        var velocidade = _rapidez * direcao;

        var qtdeMovimento = velocidade * Time.deltaTime;
        transform.Translate(qtdeMovimento);
    }
}
