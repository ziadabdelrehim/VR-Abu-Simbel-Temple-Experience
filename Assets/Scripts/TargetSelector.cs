using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TargetSelector : MonoBehaviour
{
    public GameObject Maincamera;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject Cam5;
    public GameObject Cam6;
    public GameObject Cam7;
    public GameObject Cam8;
    public GameObject Cam9;
    public GameObject Cam10;
    public GameObject Cam11;
    public GameObject Cam12;
    public GameObject Cam13;

    public GameObject inf;


    public Texture t1;
    public Texture t2;
    public Texture t3;
    public Texture t4;
    public Texture t5;
    public Texture t6;
    public Texture t7;
    public Texture t8;
    public Texture t9;
    public Texture t10;
    public Texture t11;


    public int scoreCounter = 0;
    public Text scoreText;
    public Text TimerText;
    private float startTime;



    public GameObject WatchButton;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        TimerText.text = "Visiting Time\n\t  " + minutes + " : " + seconds;


        if(Input.GetMouseButtonDown(0) && !IsMouseOverUI())
        {
            Ray ray = Camera.main.ViewportPointToRay(Vector3.one * 0.5f);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 2f);

            if (Physics.Raycast(ray , out RaycastHit hitInfo))
            {

                

                    if (hitInfo.collider.gameObject.GetComponent<TargetDetection>() != null)
                    {

                        Vector3 distanceToTarget = hitInfo.point - transform.position;
                        Vector3 forceDircetion = distanceToTarget.normalized;


                        if (hitInfo.collider.gameObject.tag == "Temsal1" || hitInfo.collider.gameObject.tag == "Temsal2" || hitInfo.collider.gameObject.tag == "Temsal3" || hitInfo.collider.gameObject.tag == "Temsal4")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                            WatchButton.SetActive(false);
                            inf.gameObject.GetComponent<InfoDialog>().ShowDialog("The Great Temple of Abu Simbel", "The Great Temple at Abu Simbel, whichtook about twenty years to build, was completed around year 24 of the reign of Ramesses the Great(which correspondsto 1265 BCE).It was dedicated to thegods Amun, Ra - Horakhty, and Ptah, aswell as to the deified Rameses himself. It is generally considered the grandest and most beautiful of the temples commissioned during the reign of Rameses Il, and one of the most beautiful in Egypt. Four colossal 20 meter statues of the pharaoh with the double Atef crown of Upper and Lower Egypt decorate the facade of the temple, which is 35 meters wide and is topped by a frieze with 22 baboons, worshippers of the sun and flank the entrance.",t1);
                        }
                        else if (hitInfo.collider.gameObject.tag == "Temsa5" || hitInfo.collider.gameObject.tag == "Temsal6" || hitInfo.collider.gameObject.tag == "Temsal7" || hitInfo.collider.gameObject.tag == "Temsal8")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                        WatchButton.SetActive(false);
                        inf.gameObject.GetComponent<InfoDialog>().ShowDialog("The Hypostyle hall", "it is 18 meters long and 16.7 meters wide and is supported by eight huge Osirid pillars depicting the deified Ramses linked to the god Osiris, the god of the Underworld, to indicate the everlasting nature of the pharaoh.", t2);
                        }
                        else if (hitInfo.collider.gameObject.tag == "Temsal9" || hitInfo.collider.gameObject.tag == "Temsal10" || hitInfo.collider.gameObject.tag == "Temsal11" || hitInfo.collider.gameObject.tag == "Temsal12")
                        {

                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                        WatchButton.SetActive(false);
                        inf.gameObject.GetComponent<InfoDialog>().ShowDialog("The Hypostyle hall", "it is 18 meters long and 16.7 meters wide and is supported by eight huge Osirid pillars depicting the deified Ramses linked to the god Osiris, the god of the Underworld, to indicate the everlasting nature of the pharaoh.", t2);
                    
                        }
                        else if (hitInfo.collider.gameObject.tag == "WallOfEnemy")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                
                        inf.gameObject.GetComponent<InfoDialog>().ShowDialog("Mural", "Ramses II  killing his enemies", t3);
                            WatchButton.SetActive(false);
                    }
                    else if (hitInfo.collider.gameObject.tag == "Room")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                        
                        inf.gameObject.GetComponent<InfoDialog>().ShowDialog("Side Hall", "Series of rooms called treasures rooms. Most likely, it was here that the most precious tools of the temple had been stored.", t4);
                            WatchButton.SetActive(false);
                    }
                        else if (hitInfo.collider.gameObject.tag == "Room2")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                            inf.gameObject.GetComponent<InfoDialog>().ShowDialog("Side Hall", "Series of rooms called treasures rooms. Most likely, it was here that the most precious tools of the temple had been stored.", t5);
                            WatchButton.SetActive(false);
                    }
                        else if (hitInfo.collider.gameObject.tag == "WallOfAttack1")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                            inf.gameObject.GetComponent<InfoDialog>().ShowDialog("Mural", "Ramesses Il on his chariot attacking an Asian fortress", t6);
                            WatchButton.SetActive(false);
                    }
                        else if (hitInfo.collider.gameObject.tag == "WallOfAttack2")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                            inf.gameObject.GetComponent<InfoDialog>().ShowDialog("Mural", "Ramesses II killing a Libyan enemy", t7);
                            WatchButton.SetActive(false);
                    }
                        else if (hitInfo.collider.gameObject.tag == "WallOfAttack3")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                            inf.gameObject.GetComponent<InfoDialog>().ShowDialog("Mural", "Ramesses II triumphant, a top of his chariot", t8);
                            WatchButton.SetActive(false);
                    }
                        else if (hitInfo.collider.gameObject.tag == "WallOfHall2")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                            inf.gameObject.GetComponent<InfoDialog>().ShowDialog("Hall of the four pillars", "The back door of large hall leads to a room with four pillars", t9);
                            WatchButton.SetActive(false);
                    }
                        else if (hitInfo.collider.gameObject.tag == "WallOfAttack4")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                            inf.gameObject.GetComponent<InfoDialog>().ShowDialog("Mural", "Scenes of worship of divine boats", t10);
                            WatchButton.SetActive(false);
                    }
                        else if (hitInfo.collider.gameObject.tag == "FinalHall")
                        {
                            scoreCounter++;
                            Maincamera.SetActive(false);
                            Cam1.SetActive(true);
                            inf.SetActive(true);
                            inf.gameObject.GetComponent<InfoDialog>().ShowDialog("The sanctuary of the Temple", "Four statues are carved into the rock representing, from left to right, Ptah, Amon - Ra, Ramesses Il and Ra - Horakhty", t11);
                            WatchButton.SetActive(false);
                    }
                    




                }
            }

                            scoreText.text = "Experience : " + scoreCounter.ToString();

        }


       /* if (Input.GetKeyDown(escape))
        {
            inf.SetActive(true);
            scoreText.text = "";
            TimerText.text = "";



        }*/
            
    }




    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }

    public int RetScore()
    {
        return scoreCounter;
    }
    public void setCounter(int count)
    {
        scoreCounter = count;
    }


} 






