# Exercícios

1. Qual é a maior utilidade de um *prefab*?

**R:** Criar um objeto de jogo composto por várias partes totalmente reutilizável na mesma cena ou em outras cenas

2. O que é um nested prefab?

**R:** É um prefab que contém outros prefabs.

3. Se, além de mudar a cor do chapéu, eu também mudasse o tamanho, essa mudança iria ser aplicada para todos os nested prefabs que usam esse chapéu?

**R:** Sim.

4. Como criar uma variante de um prefab? Escolha uma opção

A. Aperte **CTRL+D** no Prefab para duplicar ele.
B. No modo prefab, salve as alterações com um novo nome
C. Clique com o botão direito no prefab e escolha "Create > Prefab variant"

**R:** Letra C

5. Digamos que eu tenha criado uma nova variante do prefab **Pocao**. Nessa variante, eu removi o objeto de jogo Liquido em vez de mudar a cor dele, criando assim uma garrafa de poção vazia. Se eu alterar a cor da rolha ou o tamanho da garrafa no prefab base **Pocao**, essa mudança afetará as variantes também?

**R:** Isso não é possível. Não é permitido remover os objetos filhos do prefab base nas variantes. É possível, porém, desligar a visibilidade do objeto *Liquido*. Nesse caso, mudanças como as descritas iriam ser repassadas normalmente para os prefabs variantes.