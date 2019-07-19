# Arrays

## Aula

Link para vídeo-aula: https://youtu.be/DahaScn49_o

## Introdução

Até agora só mencionamos tipos de dados simples e como utilizá-los, mas não falamos ainda em como relacionar eles dentro de um mesmo conjunto. 

## Caso de uso: Material aleatório

Por exemplo, eu fiz uma cena aqui com um cubo. E também criei três materiais para a gente pintar ele. Digamos que eu queira selecionar aleatóriamente um desses materiais quando eu apertar R.

Para isso, vou criar um novo script chamado MudaCorAleatoria

```cs
[SerializeField]
private Material _material1;
[SerializeField]
private Material _material2;
[SerializeField]
private Material _material3;

void Update()
{
    if (Input.GetKeyDown(KeyCode.S))
    {
        var renderer = GetComponent<MeshRenderer>();
        renderer.material = _material1;
    }
}
```

## Criando Arrays

Para resolver esse problema podemos usar um array. Arrays funcionam como se fossem uma lista de alguma coisa. Podemos fazer arrays de _inteiros_, _strings_, _objetos_, etc.

A sintaxe para inicializar um array no código fica assim:

```cs
int[] numeros = new int[3];
```

Isso cria um array de inteiros com tamanho 3. Para preencher esse array, fazemos assim:

```cs
numeros[0] = 12; 
numeros[1] = 322;
numeros[2] = 165;
```

A primeira _'vaga'_ do array começa em 0, sendo assim, 0 é a primeira posição, 1 é a segunda, e 2 é a terceira. Um array pode ser qualquer coisa, imagina por exemplo que vc tem uma mochila que pode guardar 5 items, você poderia guardar os items num array e quando estivesse todos preenchidos você poderia enviar uma mensagem dizendo que a mochila está cheia.

## Aplicando arrays com Unity

Então, voltando para o nosso exemplo do cubo, no Unity, podemos também usar arrays no editor. Para então resolver nosso problema vamos fazer assim:

```cs
[SerializeField]
private Material[] _materiais; // Mudamos para um array de Material

void Update()
{
    if (Input.GetKeyDown(KeyCode.S))
    {
        var renderer = GetComponent<MeshRenderer>();
        var numAleatorio = Random.Range(0, 3); // Random.Range dá um número aleatório, nesse caso entre 0 (inclusivo) e 3(exclusivo)

        renderer.material = _materiais[numAleatorio];
    }
}
```

Agora se a gente voltar ao Unity e testar nossa aplicação, apertar S muda os materiais aleatóriamente!


## Exercícios

1.  Qual das linhas a seguir instancia um array de 10 elementos?

* A) int[] numeros = new int[9];
* B) int[] numeros = new int[10];
* C) int[] numeros = new int["dez"];
* D) int[10] numeros = new int[10];

2. Dado este array:

```cs
int[] numeros = new int[15];
```

Como acessar o quinto elemento nessa lista?

* A) numeros[3]
* B) numeros[4]
* C) numeros["quinto"]
* D) numeros[5]

3. (Para pesquisar) Dado um array chamado _'numero'_, como descobrir seu tamanho?

* A) numero.Length
* B) numero.Size
* C) numero.Size()
* D) numero.Length()
* E) numero.Capacity()

4. (Para pesquisar) Quando vamos instanciar e inicializar um array, fazemos assim.

```cs
int[] numeros = new int[3];
numeros[0] = 43; 
numeros[1] = 886;
numeros[2] = 563;
```

Existe uma forma mais simples de inicializar arrays em C# usando apenas uma linha de código. Qual é?
