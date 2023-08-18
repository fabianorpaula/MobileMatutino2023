using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApertarBotaoD : Button
{
    private GameObject Personagem;
    // Start is called before the first frame update
    void Start()
    {
        Personagem = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPressed() == true)
        {
            Personagem.GetComponent<Jogador>().MoverD();
        }

    }
}
