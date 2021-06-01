using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texto : MonoBehaviour
{
    public GameObject canvas; 
    public GameObject objectoClickeado;
    public GameObject objecto1;
    public GameObject objecto7;
    public GameObject objecto8;

   
    string frase1 = "Siguiendo las anteriores instrucciones cliclea 4 veces en el 'cable en curva' "; 
        
    public Text tex;
    //objecto3,objecto4,objecto5; 
    int contador = 0;
    public GameManager m,m2;

    void Start()
    {
        objecto7.SetActive(false);   
        canvas.SetActive(true);
    }

    void OnMouseDown()
    {
        m.gameObject.SetActive(false);
      
        if (objectoClickeado.tag == "Piece")  
        {       
            objecto1.SetActive(false);
            
            contador++;

            if (contador == 1)
            {
                objecto8.SetActive(false);
                StartCoroutine(Reloj1());
            }

            
            if (contador == 4)
            {
                
                objectoClickeado.SetActive(false);
                m2.gameObject.SetActive(true);
                objecto7.SetActive(true);
                tex.text = "";

                objecto7.SetActive(false);
            }

            

         

        }
    }

    IEnumerator Reloj1()
    {
        tex.text = ""; 
        foreach (char caracter in frase1)
        {
            tex.text = tex.text + caracter;
            yield return new WaitForSeconds(0.001f);
        }

    }





}