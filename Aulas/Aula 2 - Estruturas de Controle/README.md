# Aula 2: Estruturas de Controle

## Tomando decisões
Continuando o curso, fizemos uma conta de banco e temos 500 reais nela. O que acontece se eu tentar fazer uma transferência de 1000 reais? Será que o código funciona? Vamos tentar!

```cs
double saldo = 500.0;
double transferencia = 1000.0;
saldo -= transferencia;
Console.Out.WriteLine("Saldo: " + saldo);

// Resultado: 
// Saldo: -500
```

Oops... A gente não devia deixar isso acontecer! Precisamos então adicionar uma **condição** ao código. Para isso, precisamos declarar uma estrutura de controle *if-else*. A sintaxe para ela funciona assim:

```cs
if(condicao)
{
    // Código executado se 'condicao' for verdade.
}
```
Onde "condicao" é uma variável ou expressão de valor booleano. Para nosso exemplo, queremos fazer a transferência apenas se o valor for menor que nosso saldo atual.

```cs
double saldo = 500.0;
double transferencia = 1000.0;
if (saldo >= transferencia)
{
    saldo -= transferencia;
}
```

Agora o código que retira a transferencia do saldo só ocorre se a condição do if for verdadeira. No caso acima, o código não é executado. Seria uma boa avisar ao usuário o porque de ele não ser executado. Para isso vamos usar o *else*:

```cs
double saldo = 500.0;
double transferencia = 1000.0;
if (saldo >= transferencia)
{
    saldo -= transferencia;
    Console.Out.WriteLine("Sucesso!");
}
else
{
    Console.Out.WriteLine("Saldo insuficiente");
}
```

Repara que usamos um simbolo ">=" para calcular a condição. Outros operadores podem ser usados aqui como o "<=", ">", "<", e as comparações de igualdade: "!=" que significa "diferente de" e "==" que significa "igual a". Não confundir com um simbolo de igual só "=": esse é para passar valores.

## Multiplas condições

Como dito, o valor da condição resulta num tipo booleano, isso é porque o resultado da expressão "saldo >= transferencia" pode apenas ser dois: verdadeiro ou falso. E não paramos por aí... E quisermos colocar mais uma condição? Por exemplo, vamos também impedir que a transferência seja um número negativo ou seja igual a 0:

```cs
double saldo = 500.0;
double transferencia = 1000.0;
if (saldo >= transferencia)
{
    if(transferencia > 0)
    {
        saldo -= transferencia;
        Console.Out.WriteLine("Sucesso!");
    }
    
}
else
{
    Console.Out.WriteLine("Saldo insuficiente");
}
```

Mas repara que agora estamos *identando* ifs dentro de ifs... E ter mais condições iria piorar isso mais ainda! Portanto, fazer isso é considerado má prática de programação. Para tornar isso melhor e mais simples, podemos usar **operadores**  "E" (&&) e "OU" (||). Fica assim:

```cs
double saldo = 500.0;
double transferencia = 1000.0;
if ( (saldo >= transferencia) && (transferencia > 0) )
{
    saldo -= transferencia;
}
else
{
    Console.Out.WriteLine("Saldo insuficiente");
}
```

Vamos falar melhor sobre esses operadores e as combinações.

## Operadores lógicos &&, || e !

Para comparar várias expressões, usamos operadores lógicos. Eles não são nada de muito difícil e são bem parecidos como comparamos coisas na vida real.

### Operador && (AND) - "E"

Como vimos acima, o operador AND serve para compararmos duas expressões. O resultado da comparação é verdadeiro(true) ou falso(false). Se acumularmos vários AND's, o resultado apenas é verdadeiro se todas as expressões forem verdadeiras. Por exemplo:

```cs
int idade = 18;
bool temCarteira = false;
bool podeDirigir = (idade >= 18) && (temCarteira == true);
Console.Out.WriteLine("Resultado podeDirigir: " + podeDirigir);
```
O resultado de "podeDirigir" vai ser false, porque apesar da idade ser maior ou igual a 18, o *temCarteira* é falso. Aqui vai uma pequena tabela para ilustrar isso melhor:

|       | **True**  | **False** |
|-------|-------|-------|
| **True**  | True  | False |
| **False** | False | False |

Em resumo, o resultado apenas é verdadeiro se todas as expressões forem verdadeiras, senão, é falso.

### Operador || (OR) - "OU"

O operador OR serve para quando queremos que apenas uma expressão seja verdadeira para que o resultado da operação seja verdadeiro. Por exemplo, numa piscina só podem entrar pessoas acima de 15 anos ou acompanhada dos pais. Digamos uma pessoa com 13 anos acompanhada, o código ficaria:

```cs
int idade = 13;
bool estaAcompanhadaDosPais = true;
bool podeEntrarNaPiscina = (idade >= 15) || (estaAcompanhadaDosPais == true)
Console.Out.WriteLine("Resultado podeEntrarNaPiscina: " + podeEntrarNaPiscina);
```

Nesse caso, o resultado será **TRUE** porque uma das expressões é verdadeira. Caso a pessoa tivesse mais que 15 anos e fosse acompanhada dos pais, ou seja, ambas as expressões sendo true, o resultado seria verdadeiro na mesma. A tabela do OR fica assim:

|       | **True**  | **False** |
|-------|-------|-------|
| **True**  | True  | True |
| **False** | True | False |

Sendo assim, o resultado só é falso se todas as expressões forem falsas!

### Operador ! (NOT)

O operador "!" apenas define uma negação. Por exemplo, digamos que em uma festa podem entrar pessoas vestidas de todas as cores, MENOS verde. Se fôssemos usar um ||(OR) o código ficaria assim:

```cs
string cor = "vermelho";
bool podeEntrarNaFesta = (cor == "azul") || (cor == "amarelo") || (cor == "vermelho");
Console.Out.WriteLine("Resultado podeEntrarNaFesta: " + podeEntrarNaFesta);
```

*Nota: É má prática comparar strings com "==", precisamos comparar usando o método "Equals()". Para efeito de aprendizagem a gente vai usar aqui. Vamos falar mais sobre isso em outra aula, quando começarmos a falar de tipos complexos*

Repare que eu só listei três cores. Para o código ficar completamente correto, eu teria que **listar todas as cores existendes**, menos o verde! Que trabalho! Em vez de ter esse trabalho, podemos simplesmente fazer:

```cs
string cor = "vermelho";
bool podeEntrarNaFesta = !(cor == "verde");
Console.Out.WriteLine("Resultado podeEntrarNaFesta: " + podeEntrarNaFesta);
```

E pronto! Claro que também poderíamos usar o operador "!=" (DIFERENTE DE). Teria o mesmo efeito, mas acho que você entendeu a idéia!


## Lógica Matemática

Esse assunto parece um pouco bobo, mas ele é extremamente importante e pode ir bem mais a fundo. Para o que a gente precisa para o curso, isso basta, mas se você quiser saber mais sobre ele, pesquise e estude sobre **lógica matemática**.

# Exercícios

1. Sem executar o código, leia o código e diga, respectivamente, qual é a mensagem no console e o valor da variável saldo?

```cs
double saldo = 100.0; 
double valorTransferencia = 10.0; 
if (saldo >= valorTransferencia) 
{ 
    saldo -= valorTransferencia; 
    Console.Out.WriteLine("Transferência feita com sucesso!"); 
} 
else 
{ 
    Console.Out.WriteLine("Transferência falhou."); 
} 
```
A) mensagem: Transferência feita com sucesso!; variável saldo: 90.0
B) mensagem: Transferência falhou.; variável saldo: 90.0
C) mensagem: Transferência feita com sucesso!; variável saldo: 100.0
D) mensagem: Transferência falhou.; variável saldo: 100.0
E) mensagem: Transferência feita com sucesso!; variável saldo: 10.0

2. Sem executar o código, leia o código e diga, respectivamente, qual é a mensagem no console e o valor da variável saldo?

```cs
double saldo = 5.0; 
double valorTransferencia = 10.0; 
if (saldo >= valorTransferencia) 
{ 
    saldo -= valorTransferencia; 
    Console.Out.WriteLine("Transferência feita com sucesso!"); 
} 
else 
{ 
    Console.Out.WriteLine("Transferência falhou."); 
} 
```
A) mensagem: Transferência feita com sucesso!; variável saldo: -5.0
B) mensagem: Transferência falhou.; variável saldo: -5.0
C) mensagem: Transferência feita com sucesso!; variável saldo: 5.0
D) mensagem: Transferência falhou.; variável saldo: 5.0
E) mensagem: Transferência feita com sucesso!; variável saldo: 10.0

3. O *if-else* não resulta tem apenas duas possibilidades. É possível fazer varias comparações nesta estrutura de controle, por exemplo:

```cs
double saldo = 500.0; 
if (saldo < 0.0) 
{ 
    Console.Out.WriteLine("Saldo negativo"); 
} 
else if (saldo < 100000.0)
{ 
    Console.Out.WriteLine("Saldo gordinho!"); 
} 
else
{ 
    Console.Out.WriteLine("WOW, um milionário!"); 
} 
```

Tente ler o código e chegar a uma conclusão de qual mensagem será exibida para o usuário:

A) Saldo negativo
B) Saldo gordinho!
C) WOW, um milionário!

4. No Brasil, apenas pessoas maiores de 18 anos e com carteira de motorista podem dirigir.
Faça um programa com duas variáveis *idade* e *possuiCarteira* . Esse programa deverá validar a idade da pessoa e exibir a mensagem "Apto para conduzir" caso ela esteja dentro dos requisitos descritos. Exibir a mensagem "Proíbido dirigir" se a pessoa for inapta.

5. (Para pesquisar) É possível resumir o *if* em apenas uma linha usando o **operador ternário "?"**, usando a seguinte sintaxe:

```cs
var resultado = condicaoBooleana ? resultado1 : resultado2;
```

Essa linha acima também é conhecida por *inline if*. Com base nisso, transforme o seguinte código com um **if** e em vez disso use o **operador ternário "?" para diminuir as linhas de código**.

```cs
int idade = 22;
string mensagem = "";
if(idade > 18)
{
    mensagem = "Idade MAIOR que 18"; 
}
else
{
    mensagem = "Idade MENOR que 18"; 
}
Console.Out.WriteLine("Idade MENOR que 18"); 
```