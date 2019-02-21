# Tipos Primitivos e Conversão

## Tipos Primitivos
Em C#, toda variável possui um tipo. Podemos usar int para armazenar valores inteiros, double para números reais... Mas que outros tipos nós temos?
Na verdade... Muitos! Mas eles são muito parecidos entre si. Além do int, temos vários outros tipos que armazenam valores inteiros como, por exemplo, o **long**, o **short** ou até mesmo **uint** e similares!

Isso pode ser um pouco confuso no início, afinal, porque ter vários tipos que guardam o mesmo tipo de dado? Faz muito sentido separar dessa forma, mas para entender por quê, vamos ver primeiro como os computadores guardam valores em memória.


Quando declaramos uma variável, independente de preencher ela com algum valor ou não, nós utilizamos **espaço em memória**. É um espaço bem pequeno, mas ele fica alocado e tem limite! 
Os int's, por exemplo, é um tipo que ocupa 32 bits de memória. E, nesses 32 bits, é possível guardar um valor até certa quantidade, no caso do int, ele pode variar entre -2 bilhões e alguns quebrados até +2 bilhões e alguns quebrados. Portanto, quando fazemos algo do tipo

```cs
int idade = 15;
```

Estamos desperdiçando espaço em memória! Nesse caso seria muito mais interessante usar o tipo **byte**, que ocupa apenas **8 bits** de memória e guarda números de 0 a 255. Claro que é uma diferença ridiculamente pequena, e a quantidade de recursos economizada é quase irrelevante. Mas digamos que você estivesse guardando uma lista com centenas de milhões de idades de usuários. Agora começou a fazer alguma diferença, né?

Mesmo assim, limitar o tamanho da variável pode trazer outros problemas se você não tiver certeza 100% absoluta que nunca vai precisar de um número maior que a variável permite. Então a boa prática a ser ensinada aqui é: se você achar que é possível um dia precisar de um número maior que o tipo aguenta, simplesmente use o tipo com maior tamanho.

Um bom exemplo é números de identificação. Imagina que você tem um banco de dados, e você guarda o id dos usuários num tipo **byte**. Os bytes guardam números de 0 a 255, então você só poderia ter um máximo de 256 usuários na sua database! Enquanto que se você tivesse usado o tipo **ulong**, poderia guardar 18 quintilhões de usuários! Isso, claro, é um exemplo extremo, mas você entendeu a idéia.

Aqui vai umas tabelas com os diferentes tipos primitivos e seus tamanhos

## Números Integrais

|     TIPO    | TAMANHO |                           VALORES                                         |
| ----------- | ------- | ------------------------------------------------------------------------- |
|  sbyte      | 8 bits  | -128 até 127                                                              |
|  byte       | 8 bits  | 0 até 255                                                                 |
|  short      | 16 bits | -32768 até 32767                                                          |
|  ushort     | 16 bits | 0 até 65535                                                               |
|  int        | 32 bits | -2147483648 até 2147483647                                                |
|  uint       | 32 bits | 0 até 4294967295                                                          |
|  long       | 64 bits | -9223372036854775808  até 9223372036854775807                             |
|  ulong      | 64 bits | 0 até 18446744073709551615                                                |


## Números Reais

Também chamados de números de ponto flutuante.

|     TIPO    | TAMANHO  |                      VALORES                      |
| ----------- | -------- | ------------------------------------------------- |
|  float      | 32 bits  | Até 10^38 números, incluindo as casas decimais    |
|  double     | 64 bits  | Até 10^308 números, incluindo as casas decimais   |
|  decimal    | 128 bits | Números com até 28 casas decimais                 |

Note que o decimal é mais **preciso** que o double, mas só em relação às casas decimais, o double aceita números maiores que decimal, mas com menos casas decimais.

## Outros tipos primitivos

|     TIPO    | TAMANHO |                                                VALORES                                                    |
| ----------- | ------- | --------------------------------------------------------------------------------------------------------- |
|  char       | 16 bits | 0 até 65535 -> Similar a números inteiros, mas cada número representa um caracter do conjunto Unicode     |
|  bool       | 8 bits  | Verdadeiro ou Falso                                                                                       |


**Porque um bool usa 8 bits?**
Valores booleanos só guardam um tipo de valor por vez, o que significa que, teoricamente, o tamanho necessário para guardar um valor booleano é de 1 bit. Porém, hoje em dia, os processadores processam 32 ou 64 bits por vez, podendo compactar os dados em menores pacotes de 16 ou 8 bits. No fim das contas, os booleans ficam guardados em pacotes de 8 bits de qualquer forma, não tendo nenhum ganho em alocar um espaço menor em memória!


Mais informações sobre tipos primitivos [aqui](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/types#integral-types).

## Conversões

O C# possui duas formas de conversão de tipos: implícita e explícita.

Vamos supor que temos uma variável int e queremos guardá-la num long:

```cs
int idade = 20;
long idadeGigante = idade;
```

Como a gente falou antes, as variáveis **long** tem um tamanho maior que **int**. Significa que temos **SEMPRE** certeza de que o que quer que esteja guardado na variável *idade* pode ser normalmente convertido para a variável *idadeGigante*, portanto, isso é uma conversão implícita. Mas e se tentarmos a ação contrária?

```cs
int idade = 20;
short idadePequena = idade;
```

Isso vai gerar um erro de compilação. Repare que o número 20 cabe dentro de um tipo *short*, mas o compilador **não sabe disso no momento que estamos escrevendo o código**. Então, para ele ter certeza que o código não vai dar erro, ele vai reclamar dizendo que a conversão é inválida.

Podemos, porém, forçar o compilador a fazer a conversão, simplesmente dizendo qual o tipo que queremos converter:

```cs
int idade = 20;
short idadePequena = (short) idade;
```

Fazendo assim uma conversão explícita.

## Exercícios

1. O código abaixo compila?

```cs
short idade = 20;
long idadeGrande = idade;
```

1. Variáveis do tipo int e float tem um tamanho de 32 bits, portanto converter valores float para int pode ser feito implicitamente. Essa afirmação é verdadeira ou falsa?

1. O que acontece se fizermos uma conversão explícita de um valor não suportado? Por exemplo:


```cs
long valorGrandeDemais = 9223372036854775807;
int valorMenor = (int) valorGrandeDemais;
```

Qual seria o resultado ao tentar rodar esse código?
A) Erro de compilação. Esse valor é grande demais para caber num int.
B) Compila e não gera erros, mas por não conseguir armazenar o número numa variável int, é passada então o valor "-1" para a variável "valorMenor".
C) O código compila, mas vai gerar um erro quando ele tentar fazer essa conversão.
D) Compila, não gera erros, e o valor é guardado sem problema nenhum na variável int.

Se não souber a resposta, tente rodar o código e descubra por si próprio!

1. (Para pesquisar) Variáveis do tipo **char** são interessantes. Elas representam números inteiros positivos até 65535, o que significa que se fizermos esse código:

```cs
ushort valorPequeno = 65;
char charDeValorPequeno = (char)valorPequeno;
Console.Out.WriteLine("Valor do Char " + charDeValorPequeno);
```

Ele compila normalmente! Mas se então rodarmos o código, temos o resultado

```
Valor do Char: A
```

Mas o valor não era 65? O que aconteceu aqui?