# Aula 9: Rotação


## Aplicando Rotação nos scripts

Podemos mudar a rotação de um objeto de jogo através do código usando o método Rotate. Assim como fizemos com o translate nas aulas anteriores.

Então, se adicionarmos o seguinte código no nosso método update do jogador:

```cs
transform.Rotate(new Vector3(x: 0, y: 1, z: 0));
```

E em seguida colocarmos o script Jogador.cs no nosso barco, quando eu der play, o barco irá girar no eixo Y a uma velocidade de 1 unidade por frame.

Vamos então fazer um código parecido com o nosso Movimenta, mas para rotacionar o barco no eixo Y.

Criamos um método rotaciona:

```cs
[SerializeField]
private float _rapidezRotacao = 10.0f;

public void Rotaciona(float x, float y, float z)
{
    var inputJogadorRotacao = new Vector3(x, y, z);
    var direcao = inputJogadorRotacao.normalized;
    var velocidade = _rapidezRotacao * direcao;

    var qtdeMovimento = velocidade * Time.deltaTime;
    transform.Rotate(qtdeMovimento);
}
```

Depois chamamos o Rotaciona no update. Atenção que eu removi o input Horizontal do movimenta porque agora vamos rodar o objeto.

```cs
void Update()
{
    Movimenta(0, 0, Input.GetAxisRaw("Vertical"));
    Rotaciona(0, Input.GetAxisRaw("Horizontal"), 0);
}
```

E agora se fizermos Play, podemos andar com o Barco com W e S, e rotacionar com A e D. Ele está rotacionando bem lentamente porque normalizamos para a rotação ser feita em unidades por segundo.
Entretanto, como colocamos SerializeField na variável, podemos alterá-la aqui no editor, e agora já está um valor melhor

Tenha em atenção que quando você fizer uma rotação, ela será aplicada para o objeto e todos os filhos deste objeto. 
Nesse barco, por exemplo, temos mastro, velas, canhões, todos eles são rotacionados junto com o barco, que é onde está aplicado o script Jogador.

Para deixar mais claro as diferenças entre objetos de jogo pai e filho, vamos criar rapidamente um outro script chamado RotacionaVela.cs

```cs
[SerializeField]
private float _rapidezRotacao = 10.0f;

void Update()
{
    if(Input.GetKey(KeyCode.E))
        Rotaciona(0, 1, 0);
    else if (Input.GetKey(KeyCode.Q))
        Rotaciona(0, -1, 0);

}
public void Rotaciona(float x, float y, float z)
{
    var inputJogadorRotacao = new Vector3(x, y, z);
    var direcao = inputJogadorRotacao.normalized;
    var velocidade = _rapidezRotacao * direcao;

    var qtdeMovimento = velocidade * Time.deltaTime;
    transform.Rotate(qtdeMovimento);
}
```

Vou mudar a rapidez de rotação para 100. E agora se a gente der play eu posso ir para frente e para trás, posso rotacionar com A e D, e se eu apertar E e Q, eu rotaciono a vela!
Mas rotaciono apenas a vela, que é onde está meu script. O interessante é a forma como os scripts interagem. Se eu apertar A ou D para rotacionar o barco, eu posso apertar E ou Q ao mesmo tempo e vou ter total controle sobre a rotação da vela. 

Os cálculos são adaptados de acordo com a perspectiva em que o objeto se encontra.

## Exercícios

1. Ao fazer:

```cs
void Update()
{
    if(Input.GetKey(KeyCode.E))
        Rotaciona(0, 1, 0);
    else if (Input.GetKey(KeyCode.Q))
        Rotaciona(0, -1, 0);

}
```

Porque estou passando 1 e -1 para o eixo y em vez de **Input.GetAxisRaw("Horizontal")** como fiz antes? Qual é a diferença?
