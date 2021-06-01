using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class time : MonoBehaviour
{

    public static time instanciar;
    public Text Crono; 
    private TimeSpan tiempoCrono;
    private bool timebool;
    private float tiempoTrans;
    private void Awake()
    {
        instanciar = this; 


    }

    private void Start()
    {
        Crono.text = "tiempo: 00:00:00";
        timebool = false; 

    }

    public void iniciartime()
    {
        timebool = true;
        tiempoTrans = 0F;

        StartCoroutine(ActUpdate());
    }

    public void FinTiempo()
    {
        timebool = false; 
    }

    private IEnumerator ActUpdate()
    {

        while (timebool)
        {
            tiempoTrans += Time.deltaTime;
            tiempoCrono = TimeSpan.FromSeconds(tiempoTrans);
            string tiempocronostr = "tiempo: " + tiempoCrono.ToString("mm':'ss':'ff");
            Crono.text = tiempocronostr;
            yield return null; 
        }

    }



}
