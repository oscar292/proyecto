using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{

    public GameObject objectActive;
    public GameObject objeto; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetKeyDown(KeyCode.R))
        {
            objectActive.SetActive(false); 
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            objectActive.SetActive(true); 
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Pepito Perez"); 

        }
    }

}
