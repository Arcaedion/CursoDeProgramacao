
# Aula 12 - Arrays

## Exercícios com Gabarito

1.  Qual das linhas a seguir instancia um array de 10 elementos?

* A) int[] numeros = new int[9];
* B) int[] numeros = new int[10];
* C) int[] numeros = new int["dez"];
* D) int[10] numeros = new int[10];

**R:** Letra B. Na inicialização dizemos o tamanho total do array, apenas ao apontar posições que contamos a partir de 0.

2. Dado este array:

```cs
int[] numeros = new int[15];
```

Como acessar o quinto elemento nessa lista?

* A) numeros[3]
* B) numeros[4]
* C) numeros["quinto"]
* D) numeros[5]

**R:** Letra B pois as posições começam em 0.

3. (Para pesquisar) Dado um array chamado _'numero'_, como descobrir seu tamanho?

* A) numero.Length
* B) numero.Size
* C) numero.Size()
* D) numero.Length()
* E) numero.Capacity()

**R:** Letra A

4. (Para pesquisar) Quando vamos instanciar e inicializar um array, fazemos assim.

```cs
int[] numeros = new int[3];
numeros[0] = 43; 
numeros[1] = 886;
numeros[2] = 563;
```

Existe uma forma mais simples de inicializar arrays em C# usando apenas uma linha de código. Qual é?

**R:**

```cs
int[] numeros = new int[] { 43, 886, 563 };
```

Repare que desta forma você não precisa indicar o tamanho do array.
