using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHover : MonoBehaviour
{
    private Renderer item;
    private Color originalColor;
   
    
    [SerializeField] private Material highlightMaterial;


    // Start is called before the first frame update
    void Start()
    {
        item = GetComponent<Renderer>();
        originalColor = item.material.color; 

    }

    void OnMouseEnter()
    {

        item.material.SetColor("_Color", highlightMaterial.color); 
    }



    void OnMouseExit()
    {

            item.material.color = originalColor;
             
        
    }

}
