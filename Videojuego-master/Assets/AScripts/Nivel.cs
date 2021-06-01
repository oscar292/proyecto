using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class Nivel : MonoBehaviour
{

    int contador; 



    public void Restaurar()
    {
            SceneManager.LoadScene("SceneA");

        Debug.Log("Contador de Onclicks"+contador); 
    }
}
