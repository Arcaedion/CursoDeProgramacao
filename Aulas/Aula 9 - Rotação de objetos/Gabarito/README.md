# Gabarito Aula 9

1. Ao fazer:

```cs
void Update()
{
    if(Input.GetKey(KeyCode.E))
        Rotaciona(0, 1, 0);
    else if (Input.GetKey(KeyCode.Q))
        Rotaciona(0, -1, 0);

}
```

Porque estou passando 1 e -1 para o eixo y em vez de **Input.GetAxisRaw("Horizontal")** como fiz antes? Qual é a diferença?

**R:** Em ambos os casos, o valor 1 ou -1 é passado. Input.GetAxisRaw("Horizontal") obtém o valor de acordo com o controle configurado na configuração do Unity.
No caso, ele funciona ao apertar E ou A. A utilidade disso é que se eu mudar o comando "Horizontal" para outras letras, eu não preciso mudar o código, ele vai funcionar sem nenhuma mudança.