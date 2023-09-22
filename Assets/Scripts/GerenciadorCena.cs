using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorCena : MonoBehaviour
{
    
    public void ChamarCena(int CenaN)
    {
       SceneManager.LoadScene(CenaN);
    }
    
}
