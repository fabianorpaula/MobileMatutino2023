using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObjetos : MonoBehaviour
{
    public GameObject BolasDeBoliche;

    void Update()
    {
        Instantiate(BolasDeBoliche, transform.position, Quaternion.identity);
    }
}
