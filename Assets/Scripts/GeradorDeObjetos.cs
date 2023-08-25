using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObjetos : MonoBehaviour
{
    
    public List<GameObject> BolasDeBoliche;
    public float tempo = 0;

    void Update()
    {
        QuedaRandomizada();


    }

    void QuedaSimples()
    {
        tempo += Time.deltaTime;
        if (tempo > 0.5f)
        {
            tempo = 0;
            //RandomizarPosição
            float posX = Random.Range(-2, 2);
            Vector3 novaPos = new Vector3(posX, 6, 0);
            //Randomizar o Objeto
            int indice = Random.Range(0, BolasDeBoliche.Count);
            GameObject novaBolinha = Instantiate(BolasDeBoliche[indice], novaPos, Quaternion.identity);
            Destroy(novaBolinha, 2f);
        }
    }

    void QuedaRandomizada()
    {
        tempo += Time.deltaTime;
        if (tempo > 0.5f)
        {
            tempo = 0;
            //RandomizarPosição
            float posX = Random.Range(-2, 2);
            Vector3 novaPos = new Vector3(posX, 6, 0);
            //Randomizar o Objeto
            int probabilidade = Random.Range(0, 100);
            if(probabilidade < 12)
            {
                GameObject novaBolinha = Instantiate(BolasDeBoliche[0], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }else if (probabilidade < 24)
            {
                GameObject novaBolinha = Instantiate(BolasDeBoliche[1], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 36)
            {
                GameObject novaBolinha = Instantiate(BolasDeBoliche[2], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 48)
            {
                GameObject novaBolinha = Instantiate(BolasDeBoliche[3], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 55)
            {
                GameObject novaBolinha = Instantiate(BolasDeBoliche[4], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 75)
            {
                GameObject novaBolinha = Instantiate(BolasDeBoliche[5], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 85)
            {
                GameObject novaBolinha = Instantiate(BolasDeBoliche[6], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 90)
            {
                GameObject novaBolinha = Instantiate(BolasDeBoliche[7], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else
            {
                //outro objeto

            }


        }
    }
}
