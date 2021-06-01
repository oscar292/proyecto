using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class Bird : MonoBehaviour
{

    public GameObject righframe;
    public bool isenable = true;


    public Text buttonText;
    public Image buttonIcon;
    public Sprite enableIcon;
    public Sprite disableIcon; 


    public void ButtonClicked()
    {
        isenable = !isenable;
        righframe.SetActive(isenable); 

        if(isenable == true)
        {

        }



    }

}


