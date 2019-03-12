# Aula 3: Estruturas de Repetição

## Repetindo um bloco de código

Imagine que você tem a seguinte variável:

```cs
int valor = 10;
Console.Out.WriteLine(valor);
Console.ReadLine();
// Resultado: 
// 10
```

Agora vamos adicionar o valor 1 a essa variável 3 vezes, e para cada uma delas, imprimimos o valor dela:

```cs
Console
valor += 1;
Console.Out.WriteLine(valor);
valor += 1;
Console.Out.WriteLine(valor);
valor += 1;
Console.Out.WriteLine(valor);

Console.ReadLine();
// Resultado:
// 11
// 12
// 13
```

Facinho! Só porque são 3 vezes. E se precisássemos repetir isso 1000 vezes? Ou mais, e se a gente quisesse que o usuário da aplicação definisse a quantidade de vezes que teríamos que repetir? Ou seja, sequer sabemos quantas vezes teríamos que escrever o código!

## Banqueiros odeiam esse truque simples...!

Estruturas de repetição nos permite repetir um certo bloco de código quantas vezes forem necessárias.

De volta ao exemplo da última aula anterior... Suponha agora que o cliente do banco queira saber quanto ele ganhará, ao final de 1 ano, caso ele invista um valor. O investimento paga 1% do valor investido ao mês.

Por exemplo, se o cliente investir R$ 1000,00, ao final de 12 meses, terá por volta de R$ 1126,82. Em outras palavras, 

no primeiro mês, **R$ 1000,00 + R$1000,00 1% = R$ 1010,00**; 

no segundo mês, **R$ 1010,00 + R$1010,00 1% = R$ 1020,10**; 

e assim por diante. Ou seja, para calcular o quanto ele terá ao final de um ano, podemos multiplicar o valor investido 12 vezes por 1%.

Para resolvermos esse problema, precisamos fazer uso de uma estrutura de controle que **repete um determinado bloco de código até que uma condição seja satisfeita**. Essa estrutura é também chamada de **loop**.

## A estrutura *for*

### Sintaxe

Para fazer um loop em C#, utilizaremos, inicialmente, a instrução  *for*. O for é uma instrução que possui três partes: 

1. A primeira parte é a inicialização, na qual podemos declarar e inicializar uma variável que será utilizada no  for; 
2. A segunda parte é a condição do loop. Enquanto a condição do loop for verdadeira, o loop continuará executando; 
3. A terceira parte é a atualização, na qual podemos atualizar as variáveis que são utilizadas pelo for.

Cada uma das partes do for é separada por um **;** . Assim:

```cs
for(inicializacao;condicao;atualizacao)
{
  // Codigo que irá ser executado repetidamente enquanto condicao == true
}
```

### Aplicando o exemplo

Fazendo nosso exemplo, então, temos algo como:

```cs
double valorInvestido = 1000.0;
Console.Out.WriteLine("valorInvestido inicial: " + valorInvestido);
for (int i = 1; i <= 12; i+=1)
{
    valorInvestido = valorInvestido * 1.01;
}
Console.Out.WriteLine("valorInvestido Após 12 meses: " + valorInvestido);
// Resultado
// valorInvestido inicial: 1000
// valorInvestido Após 12 meses: 1126,82503013197
```

### Explicando...

Veja que nosso for começa **inicializando** a variável *i* com *1* e repete o código de dentro dele **enquanto** o valor de i for **menor ou igual (<=)** a 12, ou seja, ele só para no momento em que i for maior do que 12. 

A cada iteração desse loop, o valor de i cresce ( i += 1 ). No fim, o código de dentro do for será repetido 12 vezes, como precisávamos. 

## Estrutura *while*

### Sintaxe

Outra estrutura de repetição é a estrutura *while*, que funciona de forma bem similar ao *for*:

```cs
while (condicao)
{

}
```

### Exemplo

E escrevendo o mesmo programa com o *while*, fica assim:

```cs
double valorInvestido2 = 1000.0;
Console.Out.WriteLine("valorInvestido inicial: " + valorInvestido2);
int x = 1;
while (x <= 12)
{
    valorInvestido2 = valorInvestido2 * 1.01;
    x += 1;
}
Console.Out.WriteLine("valorInvestido Após 12 meses: " + valorInvestido2);
// Resultado
// valorInvestido inicial: 1000
// valorInvestido Após 12 meses: 1126,82503013197
```

## Exercícios

1. Analise o código abaixo. Qual é a mensagem que será exibida no console?

```cs
double valorInvestido = 3450.0;
for (int i = 1; i <= 12; i+=1)
{
    valorInvestido = valorInvestido * 1.00;
}
Console.Out.WriteLine("valorInvestido Após 12 meses: " + valorInvestido);
```
A. valorInvestido Após 12 meses: 3887,5463539553

B. valorInvestido Após 12 meses: 3887,54

C. valorInvestido Após 12 meses: 4000,00

D. valorInvestido Após 12 meses: 3450

2. Faça um programa que imprima a soma dos números de 1 até 100.

3. Analise cuidadosamente o código a seguir:

```cs
int val = 10;
while (val < 25)
{
    val += 10;
}
Console.Out.WriteLine("val: " + val);
```

Qual é o valor que este código irá imprimir?

A. val: 10

B. val: 30

C. val: 25

D. val: 20

4. Podemos demonstrar potências usando ciclos for, uma vez que elas nada mais são do que multiplicar o mesmo número repetidamente. Faça um programa que calcule o resultado de 2⁵ usando duas variáveis *int numero = 2;* e *int potencia = 5;* e um ciclo for para calcular o resultado.

5. (Para pesquisar) É muito comum adicionarmos 1 a um valor em programação. Geralmente para fazermos contadores e outros tipos de variáveis. O nome dessa ação é **incrementar**, e existe uma forma ainda mais resumida de se fazer incrementos, usando o operador *++*. Pesquise sobre como usar esse operador, e substitua ele no seguinte código sem alterar o resultado final:

```cs
int exercicioIncremento = 10;
exercicioIncremento += 1;
Console.Out.WriteLine("exercicioIncremento: " + exercicioIncremento);
```

6. (Para pesquisar) Existe ainda uma estrutura de repetição parecida com o *while*, o *do...while*. Pesquise um pouco sobre ele e substitua o loop *while* abaixo por um *do...while*:

```cs
int val = 10;
while (val < 5)
{
    val += 10;
}
Console.Out.WriteLine("val: " + val);
```

O resultado é o mesmo? Por que?

7. (Para pesquisar + Desafio) Em matemática, sabemos que um número é múltiplo de 3 quando dividimos esse número por 3 e verificamos que não há resto (resto = 0). O número 4, por exemplo, não é múltiplo de 3 porque, nesse caso, o resultado de **4/3 = 1, com resto 1**. Para sabermos o **resto** de uma divisão, a operação **MOD** é usada (abreviação da palavra "modulo"). Em programação, usa-se o operador **%**. Se fizermos o exemplo mencionado em programação, fica:

```cs
double resto = 4 % 3;
Console.Out.WriteLine("resto: " + resto);
```

Com base nisso, faça um programa que imprima todos os números entre 1 e 100 que são múltiplos de 3.
