using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorDeJogoVazio : MonoBehaviour
{
    // Não alterar
    [Header("Configurações de Formas e Cores")]
    [SerializeField]
    private Text _formaAtualTxt;
    [SerializeField]
    private Text _corAtualTxt;
    [SerializeField]
    private string[] _nomesFormas;
    [SerializeField]
    private string[] _nomesCores;
    [SerializeField]
    private Mesh[] _meshFormas;
    [SerializeField]
    private Material[] _materialCores;
    [SerializeField]
    private GameObject _formaObj;

    [Header("Pontuação")]
    [SerializeField]
    private Text _pontuacaoAtualTxt;

    private MeshFilter _meshFilterForma;
    private MeshRenderer _meshRendererForma;

    void Start()
    {
        _meshFilterForma = _formaObj.GetComponent<MeshFilter>();
        _meshRendererForma = _formaObj.GetComponent<MeshRenderer>();
        SorteiaNovoRound();
    }
    // Não alterar

    // Codifique a partir desta linha
    [Header("Crie novas variáveis aqui")]
    [SerializeField]
    private string _exemplo = "exemplo";

    private int _formaAtualNum = 0;
    private int _corAtualNum = 0;
    private int _pontuacaoAtual = 0;

    public void SorteiaNovoRound()
    {
        // Sorteia uma forma e uma cor dos arrays _nomesFormas e _nomesCores
        // Para atualizar o texto do UI, faça:
        // _formaAtualTxt.text = nomeDaNovaForma;
        // _corAtualTxt.text = nomeDaNovaCor;
        var numeroForma = Random.Range(0, _nomesFormas.Length);
        var numeroCor = Random.Range(0, _nomesCores.Length);

        var nomeFormaAtual = _nomesFormas[numeroForma];
        var nomeCorAtual = _nomesCores[numeroCor];

        _formaAtualTxt.text = nomeFormaAtual;
        _corAtualTxt.text = nomeCorAtual;

    }

    void Update()
    {
        // Seleciona a forma pressionada pelo jogador
        // [...] Codigo que seleciona forma
        // Dica: Usar _meshFilterForma.mesh = novaForma;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(_formaAtualNum == _nomesFormas.Length - 1)
            {
                _formaAtualNum = 0;
            }
            else
            {
                _formaAtualNum++;
            }
            _meshFilterForma.mesh = _meshFormas[_formaAtualNum];
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(_formaAtualNum == 0)
            {
                _formaAtualNum = _nomesFormas.Length - 1;
            }
            else
            {
                _formaAtualNum--;
            }
            _meshFilterForma.mesh = _meshFormas[_formaAtualNum];
        }
        // Seleciona a cor Pressionada pelo jogador
        // [...] Codigo que seleciona cor
        // Dica: Usar _meshRendererForma.material = novaCor;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(_corAtualNum == _nomesCores.Length - 1)
            {
                _corAtualNum = 0;
            }
            else
            {
                _corAtualNum++;
            }
            _meshRendererForma.material = _materialCores[_corAtualNum];
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(_corAtualNum == 0)
            {
                _corAtualNum = _nomesCores.Length - 1;

            }
            else
            {
                _corAtualNum--;
            }
            _meshRendererForma.material = _materialCores[_corAtualNum];
        }

        // Verificar forma e cor atual
        // Se estiver selecionada corretamente, adiciona um ponto e sorteia novo round
        // Usando o método SorteiaNovoRound() e a variavel _pontuacaoAtualTxt, que é o texto da pontuação
        // [...] Codigo que verifica forma e cor
        if (_nomesCores[_corAtualNum].Equals(_corAtualTxt.text) && _nomesFormas[_formaAtualNum].Equals(_formaAtualTxt.text))
        {
            _pontuacaoAtual++;
            _pontuacaoAtualTxt.text = _pontuacaoAtual.ToString();
            SorteiaNovoRound();
        }
    }



}
