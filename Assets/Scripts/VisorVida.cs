using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VisorVida : MonoBehaviour
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
        texto.text = "Vida: " + GJ.InformaVida().ToString();
    }
}
