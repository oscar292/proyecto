﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  

     void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Animaciones", LoadSceneMode.Single); 
    }
}
