using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

  
    public Text LinternaUi; 


    public float veloidad = 3f; 
    int contador = 0;
    public Light flashilight;
    public float power;
    public float powerloss;
    public GameObject player;
    public GameObject[] baterias; 
    public GameObject ContinuarOtroReto;
    public GameObject Restart;
    public float fireRate = 0.5f;
    public float speed = 4.0f;
    private const string horizontal = "Horizontal";
    private const string vertical = "Vertical";
    private Animator animator; 
    void Start()
    {
        
        animator = GetComponent<Animator>(); 

        ContinuarOtroReto.gameObject.SetActive(false);
        Restart.gameObject.SetActive(false);
        power = 100;
    }

    void Update()
    {


        LinternaUi.text = " " + power;
        power -= Time.deltaTime * powerloss;
        if (Input.GetKey(KeyCode.LeftArrow))
        {    
            transform.position += Vector3.left * veloidad * Time.deltaTime;
            flashilight.transform.rotation = Quaternion.Euler(180,90,90); 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * veloidad * Time.deltaTime;
            flashilight.transform.rotation = Quaternion.Euler(0, 90, 90);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * veloidad * Time.deltaTime;
            flashilight.transform.rotation = Quaternion.Euler(270, 90, 90);
        }
         if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * veloidad * Time.deltaTime;
            flashilight.transform.rotation = Quaternion.Euler(90, 90, 90);
        }
        animator.SetFloat(horizontal, Input.GetAxisRaw(horizontal));      
        animator.SetFloat(vertical, Input.GetAxisRaw(vertical));
     
        if (power <= 0) power = 0;
        if (power == 0)
        {
            contador++;
            if(contador==0 || contador == 1)
            {
                flashilight.enabled = false;
                Restart.gameObject.SetActive(true);
            }
            else
            {
                player.SetActive(false); 
                Restart.gameObject.SetActive(true);
                ContinuarOtroReto.gameObject.SetActive(true);
            }
        }
      //  if (power > 0) if (Input.GetKeyDown(KeyCode.F)) FlashLightOn();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerSecond"))
        {
            if (power > 0) power += 20;
            baterias[0].SetActive(false);
        }

        if (collision.CompareTag("PlayerT"))
        {
            if (power > 0) power += 20;
            baterias[1].SetActive(false);
        }

        if (collision.CompareTag("PlayerQ"))
        {
            if (power > 0) power += 20;
            baterias[2].SetActive(false);
        }

        if (collision.CompareTag("PlayerR"))
        {
     
           if (power > 0) power += 20;
            baterias[3].SetActive(false);

        }

        if(collision.CompareTag("PlayerY"))
        {
            if (power > 0) power += 40;
            baterias[4].SetActive(false);
        }

        if (collision.CompareTag("PlayerX"))
        {
            if (power > 0) power += 40;
            baterias[5].SetActive(false);
        }


        if (collision.CompareTag("B1"))
        {
            if (power > 0) power += 40;
            baterias[6].SetActive(false);
        }

        if (collision.CompareTag("B2"))
        {
            if (power > 0) power += 40;
            baterias[7].SetActive(false);
        }

        if (collision.CompareTag("B3"))
        {
            if (power > 0) power += 40;
            baterias[8].SetActive(false);
        }

        if (collision.CompareTag("B4"))
        {
            if (power > 0) power += 40;
            baterias[9].SetActive(false);
        }


        if (collision.CompareTag("B5"))
        {
            if (power > 0) power += 40;
            baterias[10].SetActive(false);
        }

        if (collision.CompareTag("B6"))
        {
            if (power > 0) power += 40;
            baterias[11].SetActive(false);
        }

        if (collision.CompareTag("B7"))
        {
            if (power > 0) power += 40;
            baterias[12].SetActive(false);
        }
    }

    public void FlashLightOn(){
        if (flashilight.enabled) flashilight.enabled = false;
        else flashilight.enabled = true;
    }

   
    
  
   

   

}


