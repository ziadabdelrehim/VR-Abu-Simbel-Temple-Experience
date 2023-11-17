using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TargetDetection : MonoBehaviour
{

    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            renderer.material.color = Color.red;
        }

            
    }

    private void OnMouseExit()
    {
        
            renderer.material.color = Color.white;
        
            
    }
}
