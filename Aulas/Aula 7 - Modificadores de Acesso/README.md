# Modificadores de acesso

## Video-aula

Vídeo da aula: 

## Boas práticas

Na última aula definimos o movimento do jogador no nosso script **Jogador.cs**

```cs
public class Jogador : MonoBehaviour
{
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
```

Tudo OK, isso funciona do jeito que queremos, mas para tal quebramos algumas boas práticas. Mas vamos resolver isso nessa aula, primeiro vamos entender o problema...

Para começar, o movimento está preso a essa *rapidêz*. Ela sempre vai ter o valor **10.0f**. E se quiséssemos, por exemplo, modificar ela pelo editor do Unity para testar? Temos que, de alguma forma, poder modificar essa variável. Para tal, fazemos uma variável global pública nessa classe:

```cs
public float rapidez = 10.0f;

void Update()
{
    var inputJogador = new Vector3(Input.GetAxisRaw("Vertical"), 0, Input.GetAxisRaw("Horizontal"));
    var direcao = inputJogador.normalized;
    var velocidade = rapidez * direcao;

    var qtdeMovimento = velocidade * Time.deltaTime;
    jogador.transform.Translate(qtdeMovimento);
}
```

P.S.: Lembre-se de remover a criação da variavel local rapidez dentro do Update!

Legal, se a gente salvar esse código e ir para o Unity, podemos dar play e vai tudo funcionar exatamente como antes, mas agora no Inspector temos a variável rapidez e podemos alterá-la o quanto quisermos e ver as alterações em tempo real!

Mas tem um problema, tornar a variável pública deixa o acesso dela livre para o Unity Editor, **mas também para outras classes e scripts**!

E qual é o problema disso? Bem, agora qualquer um pode mudar a rapidêz sem a gente saber! Imagina que você tem um colega trabalhando no mesmo jogo, e ele fez um outro objeto de jogo, uma esfera. Ele pode criar uma variável *jogador*, assim:

```cs
public Jogador jogador;
```

E depois ele pode alterar a rapidez:


```cs
public Jogador jogador;
void Update()
{
    jogador.rapidez = 20.0f;
}
```

Bem, não era para ser assim. Eu só queria poder mudar a rapidez usando o Editor do Unity!

É fácil de resolver. Se voltarmos ao **Jogador.cs**, vemos que a nossa variável *rapidez* está pública. Quando usamos o modificador de acesso public, significa que qualquer um tem acesso àquela variável, de qualquer parte do código. Vamos então mudar para private. Vou aproveitar para mudar o nome, porque, por padrão, todas as variáveis privadas começam por underscore **_** . Assim sabemos na classe toda que aquela variável é privada. 

```cs
private float _rapidez;
```

E funciona! Não podemos mais mudar a rapidêz a partir de outras classes... Se formos na classe da esfera, dá erro. Mas espera... Agora não podemos alterar a variável pelo editor!!! *sight...*

## A benção do SerializeField

E agora? Há uma solução. Vamos adicionar um **Atributo** à nossa variável. Vamos falar mais a fundo sobre atributos em outras ocasiões, mas por agora só precisamos saber que podemos colocar eles antes de campos, classes e métodos e eles, basicamente, **definem funcionalidade adicional para estes**.

No caso, vamos usar um atributo chamado ***SerializeField***. Por padrão, o Unity *serializa* os campos públicos para mostrar no editor. Serializar signfica simplesmente tornar legível para integração(nesse caso, para integrar o editor do unity com o seu código C#). Se um campo privado tiver o *SerializeField*, o Unity consegue fazer ele aparecer no editor.

Para mais informações sobre o SerializeField, recomendo ler a documentação do Unity: 

https://docs.unity3d.com/ScriptReference/SerializeField.html

No fim, na classe **Jogador.cs**, a nossa variável fica assim:

```cs
[SerializeField]
private float _rapidez;
```

## Exercícios

1. Temos a seguinte classe:
```cs
public class Pessoa : MonoBehaviour
{
    public float altura;

    private string nome;

    [SerializeField]
    private int idade;
}
```

Qual dessas variáveis podem ser acessadas por outras classes?

R: Apenas "altura". "Idade" não pode ser acessada porque o SerializeField apenas permite que o EDITOR do Unity tenha acesso a elas

1. (Para pesquisar) Que outros modificadores de acesso existem em C#? Para que servem?

R:
public: Acesso irrestrito.
protected: O acesso é limitado à classe que o contém ou aos tipos derivados da classe.
internal: Acesso limitado ao assembly* atual.
private: O acesso é limitado à classe que o contém.

*: Assembly é a saída compilada do seu código, Ao compilar, o seu código gera .DLL's ou .EXE's tipicamente, esses são assemblies.
