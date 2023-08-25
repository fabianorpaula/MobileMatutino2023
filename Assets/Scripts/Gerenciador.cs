using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerenciador : MonoBehaviour
{
    public int Vida = 3;
    public int Pontos = 0;
    

    public void PerdeVida()
    {
        Vida--;
        if (Vida < 1)
        {
            Debug.Log("Morreu");
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

}
