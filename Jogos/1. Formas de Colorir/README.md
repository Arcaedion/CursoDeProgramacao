# Jogo 1: Formas de Colorir

E aí, beleza? Hoje vamos __completar um jogo__! O objetivo aqui é treinar um pouco mais a programação com pequenos joguinhos.

Mas antes de mais nada, para seguir essa aula, vc precisa baixar o projeto da aula. O Link ta na descrição. Você só precisa fazer __UNZIP__ e colocar o conteúdo dentro da sua pasta assets do Unity.

Vamos abrir a cena Jogo1_vazio

[FormasDeColorir](colorir.png)

Você tá vendo aqui na tela a base de um jogo. O jogo se chama __Formas de Colorir__, e o objetivo é selecionar a forma e a cor correta. Ao iniciar, uma forma e uma cor será sorteada. O jogador então tem que apertar as setas para o lado esquerdo ou direito para selecionar uma forma, e para cima e baixo para selecionar uma cor.

A forma e a cor selecionadas tem que combinar com o pedido. Se o jogador escolher ambos de forma correta, ele ganha um ponto e uma nova combinação é sorteada. É isso.

Mas se eu der play, nada acontece! 

```cs
public void SorteiaNovoRound()
{
    // Sorteia uma forma e uma cor dos arrays _nomesFormas e _nomesCores
    // Para atualizar o texto do UI, faça:
    // _formaAtualTxt.text = nomeDaNovaForma;
    // _corAtualTxt.text = nomeDaNovaCor;
}
```

Agora, aqui na cena, além da Forma, você tem um GerenciadorDeJogo com um script. Dentro desse script tem um método chamado SorteiaNovoRound(). Tente fazer um código em que você sorteia um novo round usando os arrays já definidos. 

[ArraysEditor](ArraysEditor.png)

Esses arrays você pode ver aqui no editor. Com os nomes das formas e cores, e com os objetos relacionados. A gente poderia organizar isso melhor e colocar eles dentro de classes, mas vamos fazer isso em outro jogo para manter esse mais simples.

Ah, e não se preocupa com essas variáveis de texto de UI, ainda não falei específicamente neles, mas eles são apenas o texto que aparece na tela.

```cs
void Update()
{
    // Seleciona a forma pressionada pelo jogador
    // [...] Codigo que seleciona forma
    // Dica: Usar _meshFilterForma.mesh = novaForma;

    // Seleciona a cor Pressionada pelo jogador
    // [...] Codigo que seleciona cor
    // Dica: Usar _meshRendererForma.material = novaCor;

    // Verificar forma e cor atual
    // Se estiver selecionada corretamente, adiciona um ponto e sorteia novo round
    // Usando o método SorteiaNovoRound() e a variavel _pontuacaoAtualTxt, que é o texto da pontuação
    // [...] Codigo que verifica forma e cor

}
```

Depois de fazer um código que sorteia um novo round, tá na hora de permitir o jogador de escolher uma forma e cor com as setas do teclado. Se tiver dúvidas, reveja a classe ComportamentoExemplo.cs que fizemos na aula 5 do curso para ver como obter o Input do jogador.

Para alterar a forma, use:

```cs
_meshFilterForma.mesh = suaForma;
```

Para alterar a cor, ou seja, o material, use:

```cs
_meshRendererForma.material = suaCor;
```

E por fim, para alterar o texto da pontuação, use:

```cs
_pontuacaoAtualTxt.text
```

Pronto! Boa sorte com o jogo! Agora pause o video para trabalhar no jogo. Para ver a resposta, continue vendo!

Para ver a resposta, veja o [Gabarito](Gabarito)