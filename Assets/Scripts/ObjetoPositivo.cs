using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoPositivo : MonoBehaviour
{
    public int qtdPontos = 0;
    private Gerenciador GJ;
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GJ.GanharPontos(qtdPontos);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Lixeira")
        {
            Destroy(this.gameObject);
        }
    }
}
