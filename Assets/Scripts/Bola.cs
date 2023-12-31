using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    private Gerenciador GJ;
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GJ.PerdeVida();
            Destroy(this.gameObject);
        }

        if(collision.gameObject.tag == "Lixeira")
        {
            Destroy(this.gameObject);
        }
    }
}
