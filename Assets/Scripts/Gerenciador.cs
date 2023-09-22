using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerenciador : MonoBehaviour
{
    public int Vida = 3;
    public int Pontos = 0;
    public GameObject TelaMorte;
    private Banco meuBanco;

    private void Start()
    {
        meuBanco = GetComponent<Banco>();
        Pontos = meuBanco.SaldoDinheiro();
    }

    private void Update()
    {
        
    }

    public void PerdeVida()
    {
        Vida--;
        if (Vida < 1)
        {
            Morreu();
        }
    }

    public int InformaVida()
    {
        return Vida;
    }

    public void GanharPontos(int qtdPontos)
    {
        Pontos = Pontos + qtdPontos;
    }

    public int InformaPontos()
    {
        return Pontos;
    }

    public void Morreu()
    {
        meuBanco.GuardarDinheiro(Pontos);
        Time.timeScale = 0;
        TelaMorte.SetActive(true);
    }

    public void Reviver()
    {
        Time.timeScale = 1;
        TelaMorte.SetActive(false);
        Vida = 1;
    }
}
