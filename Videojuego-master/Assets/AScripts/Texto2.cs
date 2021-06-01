using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Texto2 : MonoBehaviour
{
    texto t;
    public GameObject canvas;
    string frase1 = "Tambien se tendra en cuenta el tiempo en que usted realiza las conexiones";
    public Text tex;
    void Start()
    {
        canvas.SetActive(true);
        StartCoroutine(Reloj1());
    }


    IEnumerator Reloj1()
    {
   
        foreach (char caracter in frase1)
        {
            tex.text = tex.text + caracter;
            yield return new WaitForSeconds(0.001f);
        }
    }
}
