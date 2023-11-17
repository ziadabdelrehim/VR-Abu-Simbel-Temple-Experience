using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;


public class InfoDialog : MonoBehaviour
{

    
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI infoText;
    public RawImage Image;

    public GameObject Maincamera;
    public GameObject Cam1;


    // Start is called before the first frame update




    private void Awake()
    {


    }


    public void ShowDialog(string title, string Discreption, Texture texture)
    {
        
        titleText.text = title;
        infoText.text = Discreption;
        Image.texture = texture;
    


  
        

    }

    public void Hide()
    {
       
            titleText.text = "ana shaghal w rabna";
            gameObject.SetActive(false);
            Maincamera.SetActive(true);
            Cam1.SetActive(false);


    }


}
