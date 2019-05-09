## Gabarito

1. Temos a seguinte classe:
```cs
public class Pessoa : MonoBehaviour
{
    public float altura;

    private string nome;

    [SerializeField]
    private int idade;
}
```

Qual dessas variáveis podem ser acessadas por outras classes?

**R:** Apenas "altura". "Idade" não pode ser acessada porque o SerializeField apenas permite que o EDITOR do Unity tenha acesso a elas

2. (Para pesquisar) Que outros modificadores de acesso existem em C#? Para que servem?

**R:**
public: Acesso irrestrito.
protected: O acesso é limitado à classe que o contém ou aos tipos derivados da classe.
internal: Acesso limitado ao assembly* atual.
private: O acesso é limitado à classe que o contém.

*: Assembly é a saída compilada do seu código, Ao compilar, o seu código gera .DLL's ou .EXE's tipicamente, esses são assemblies.