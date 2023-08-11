using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObjetos : MonoBehaviour
{
    
    public List<GameObject> BolasDeBoliche;
    public float tempo = 0;

    void Update()
    {
        tempo += Time.deltaTime;
        if(tempo > 0.5f){
            tempo = 0;
            //RandomizarPosição
            float posX = Random.Range(-2, 2);
            Vector3 novaPos = new Vector3(posX, 6, 0);
            //Randomizar o Objeto
            int indice = Random.Range(0, 4);
            GameObject novaBolinha = Instantiate(BolasDeBoliche[indice], novaPos, Quaternion.identity);
            Destroy(novaBolinha, 2f);
        }
        
    }
}
