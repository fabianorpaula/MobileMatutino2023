using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public bool botaoAtivado = false;
    
    void Update()
    {
        if(botaoAtivado == false)
        {
            MoverDedo();
        }
        
        
    }

    void MoverDedo()
    {
        if (Input.GetMouseButton(0))
        {
            //Posição do Mouse
            Vector3 destino = Input.mousePosition;
            //Corrigir Posição
            Vector3 destinoCorrigido = Camera.main.ScreenToWorldPoint(destino);
            //Travar em X e Y
            Vector3 destinoFinal = new Vector3(destinoCorrigido.x, -4 + 0.5f, 0);
            //Jogador Segue
            transform.position = Vector3.MoveTowards(transform.position, destinoFinal, 0.1f);
        }
    }

    public void MoverE()
    {
        Vector3 destinoFinal = new Vector3(-2f, -4 + 0.5f, 0);
        //Jogador Segue
        transform.position = Vector3.MoveTowards(transform.position, destinoFinal, 0.01f);
    }

}
