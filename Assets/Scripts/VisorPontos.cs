using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VisorPontos : MonoBehaviour
{
    private TMP_Text texto;
    private Gerenciador GJ;
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
        texto = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "Pontos: " + GJ.InformaPontos().ToString();
    }
}
