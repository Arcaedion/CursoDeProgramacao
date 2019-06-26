## Exercícios (GABARITO)

1. Como faríamos para mudar a cor para azul em vez de vermelho?

**R:** Trocar o código para:

```cs
_renderer.material.color = Color.blue;
```

**Color.blue**

2. Faça um efeito de *toggle* entre azul e vermelho. Ou seja, se o cubo estiver vermelho e o botão R for apertado, ele muda para azul, e vice-versa

**R:** Usando um if para verificar se a cor atual é vermelho

```cs
if(_renderer.material.color == Color.red)
    _renderer.material.color = Color.blue;
else
    _renderer.material.color = Color.red;
```

3. (Para pesquisar) Além do Start(), há também o método Awake() na classe MonoBehavior que faz uma função semelhante, mas com algumas diferenças. Pesquise sobre o método Awake() e, considerando o exemplo da aula em que inicializamos uma variável, qual era o método mais adquado para usar naquela situação? Start() ou Awake()? 
Dica: Pesquise na documentação do Unity: https://docs.unity3d.com/ScriptReference/index.html e https://docs.unity3d.com/Manual/index.html. É um hábito MUITO importante!

**R:** O método *Awake()* é usado para inicializar variáveis ou estados antes mesmo do jogo começar. Portanto, ele é chamado apenas uma vez durante toda a vida do script. Isso significa que se um objeto for disabled e depois enabled, o script não vai executar, enquanto que o *Start()* iria. Com isso, podemos concluir que o ideal seria apenas inicializar variáveis no Start() caso elas possam mudar posteriormente. Se elas permanecerem estáticas, deveriam ser inicializadas no Awake.

No exemplo da aula, considerando apenas o código mostrado, **o melhor seria ter inicializado o _renderer no Awake.**

4. (Para pesquisar) Além do método *Update()*, há também o *FixedUpdate()*, que é similar. Qual é a diferença deles e quando é melhor usar um ou outro?

**R:** O FixedUpdate é sempre chamado em um frame fixo de acordo com a frequencia do sistema de física. O que significa que se o jogo estiver rodando a 100 FPS ou a 10 FPS, o FixedUpdate será chamado o mesmo número de vezes. Ele é ideal para o caso de fazermos alterações físicas a um objeto, como por exemplo aplicar aceleração, pois assim o resultado não será afetado pela performance do jogo.

5. (Para pesquisar) Se o *Update()* ocorre em todo frame, e é perfeitamente possível rodar jogos a mais de 100 FPS(frames por segundo), de que forma é possível termos por exemplo um relógio de contagem regressiva que é atualizado a cada update? Como podemos ter controle sobre o tempo?

**R:** Usando *Time.deltaTime*. Essa properiedade retorna o tempo entre o frame atual e o anterior, sendo assim possível "normalizar" a contagem de tempo entre frames e sendo completamente independente à performance.
