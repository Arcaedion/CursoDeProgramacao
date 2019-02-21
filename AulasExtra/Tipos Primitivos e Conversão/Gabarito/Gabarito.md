# Tipos Primitivos e Conversão: Gabarito

## 1)

Resposta: Sim. Tipos **short** tem tamanho menor que long e portanto a conversão implícita é possível.

## 2) 

Resposta: Falsa. É possível fazer uma conversão implícita de int para float, mas não o contrário. Isso é porque todo valor inteiro de um int cabe num float, mas os valores quebrados/decimais de um float não cabem num int. Portanto, apesar de eles terem o mesmo tamanho em memória, é impossível converter implícitamente. É possível, porém, fazer a conversão explícita, como por exemplo:

```cs
float pi = 3.14f;
int piInteiro = (int)pi;
```
Apenas a parte inteira do valor float iria ser guardada na variável int. No caso, 3.

## 3)

Resposta: Letra B, compila e não gera erros, mas o valor guardado no int é -1. O número é grande demais para caber num int, então, para não gerar erro, o compilador passa o valor -1.

## 4)

Resposta: Variáveis do tipo char representam diretamente caracteres do conjunto Unicode. Cada número que um char suporta um caracter. No caso, o número 65 representa a letra A maiúscula.