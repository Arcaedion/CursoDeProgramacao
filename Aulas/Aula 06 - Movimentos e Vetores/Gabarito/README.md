## Gabarito

1. Ao criar o Vector3, fazemos

```cs
var inputJogador = new Vector3(Input.GetAxisRaw("Horizontal"), 0 ,Input.GetAxisRaw("Vertical"));
```

Por que passamos o input Vertical para o eixo Z, e não para o Y, que é a altura?
**R:**
Repare que o segundo argumento, que representa o argumento para o eixo y, passamos "0". Isso é porque não queremos que, ao apertar para cima, o jogador **suba**, mas sim queremos que ele se mova na profundidade do plano. Em jogos em duas dimensões, geralmente usa-se o GetAxisRaw("Vertical") para o eixo y.

2. (Para pesquisar) Se em vez de usar o método *Translate*, usássemos:

```cs
transform.position += qtdMovimento;
```

Qual seria a diferença?

**R:**
Nenhuma. O método Translate do transform faz, em resumo:

```cs
 public void Translate(Vector3 translation)
 {
    this.position += translation;
 }
```

Ou seja, você pode usar uma forma ou outra, é indiferente, só mantenha a consistência!

