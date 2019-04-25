
## Introdução

**Vídeo da aula: https://youtu.be/K7Ne0wzyNbA**

## Vetores

Vetores são usados para definir direções, velocidades e posições.

Em um espaço tridimensional, temos a noção de largura(x), altura(y) e profundidade(z) e, para definir um ponto específico no plano, precisamos de três valores para representar cada um desses conceitos. 


[Vector3](\Vector3.png)

Em Unity, temos um objeto que representa esse ponto e contém todas essas informações. Esse objeto é um **Vector3**.

Para manter as coisas um pouco mais simples, vamos pensar em planos bidimensionais e ignorar a profundidade(z) por enquanto.

Um ponto num plano bidimensional pode ser definido com um **Vector2**.

Vamos dizer um ponto com os valores de x=4 e y=3:

[Vector2_4_3](\4-3.png)

Agora vamos treinar um pouquinho a matemática, mas é bem fácil. Um Vetor possui Direção, que aponta para o ponto no plano 2D, e uma *magnitude*, que nada mais é que o comprimento do ponto [0,0] até o ponto [4,3].

Para calcular a magnitude podemos usar o teorema de Pitágoras:

m = SQRT(4^2 + 3^2)
m = SQRT(16 + 9)
m = SQRT(25)
m = 5


Tudo isso é importante para a segunda parte dessa aula em que vamos fazer um objetos seguir o outro usando esses conceitos

## Movimentos

Vamos então fazer um objeto andar num plano 3D!

Todo objeto de jogo em Unity tem um componente Transform, que podemos usar para alterar a posição, rotação e escala do objeto. 

[Transform](\Transform.png)


Podemos também modificar essas propriedades a partir de um Script! Vamos começar por criar um Script Jogador no projeto e colocá-lo no projeto.

Aqui dentro, no Start(), escrevemos transform com letra minúscula(o com letra maiúscula se refere à classe, o com letra minúscula se refere ao transform que faz parte do GameObject em que o Script está atrelado) ponto position e passamos um Vector3 com os valores:

```cs
transform.position = new Vector3(0,10,0);
```

Quando dermos play vamos ver que a posição do cubo mudou imediatamente. É assim que mudamos a posição usando scripts!

Agora vamos remover o start e vamos nos concentrar nos método Update().

Primeiro, vamos obter um Vector3 que define a direção que o jogador apertou. Fazemos isso usando o método Input.GetAxisRaw(). Quando esse método retorna um valor negativo, simplesmente significa que ele está no lado negativo do plano. Portanto fica assim:

```cs
var inputJogador = new Vector3(Input.GetAxisRaw("Horizontal"), 0 ,Input.GetAxisRaw("Vertical"));
```

Portanto em seguida precisamos definir uma direção, e para tal temos que **normalizar desse vetor**. Manualmente, isso significaria dividir cada eixo pela magnitude para criar um novo ponto, mas isso já está implementado na classe Vector3, então tudo que precisamos fazer é:

```cs
var direcao = inputJogador.normalized;
```

Em seguida, precisamos calcular a velocidade. A velocidade nada mais é que multiplicar a direção pela rapidêz. Portanto, como exemplo, fazemos:

```cs
var rapidez = 10.0f;
var velocidade = rapidez * direcao;
```

Agora tem um passo muito importante. Com a velocidade, precisamos definir uma quantidade de movimento, e para isso precisamos normalizar ela de acordo com a diferença de tempo desde o ultimo frame processado. Conseguimos isso usando Time.deltaTime

```cs
var qtdMovimento = velocidade * Time.deltaTime;
```

Por ultimo, adicionamos essa quantidade de movimento à posição através do método Translate:

```cs
transform.Translate(qtdMovimento);
```


Muito bem, ficamos por aqui pessoal. Espero que tenham gostado, like subscribe e nos vemos no próximo video!


## Exercícios
[Gabarito](Gabarito)

1. Ao criar o Vector3, fazemos

```cs
var inputJogador = new Vector3(Input.GetAxisRaw("Horizontal"), 0 ,Input.GetAxisRaw("Vertical"));
```

Por que passamos o input Vertical para o eixo Z, e não para o Y, que é a altura?

2. (Para pesquisar) Se em vez de usar o método *Translate*, usássemos:

```cs
transform.position += qtdMovimento;
```

Qual seria a diferença?

