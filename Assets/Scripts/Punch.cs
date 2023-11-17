using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punch : MonoBehaviour
{

    
    public int scoreCounter = 0;
    public Text scoreText;






    private void OnTriggerEnter(Collider other)
    {

        //  if(other.gameObject.tag=="Player" && Input.GetMouseButtonDown(1))
        // {
            var player = other.GetComponent<TargetSelector>();
            if(player!=null && Input.GetMouseButtonDown(1))
        {
            scoreCounter = player.gameObject.GetComponent<TargetSelector>().RetScore();
            if(scoreCounter >0)
            {
                scoreCounter--;
                scoreText.text = "Experience : " + scoreCounter.ToString();
                player.gameObject.GetComponent<TargetSelector>().setCounter(scoreCounter);
            }
           
        }
          

            
        //}
       
    }

}
