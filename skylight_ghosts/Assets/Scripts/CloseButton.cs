using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CloseButton : MonoBehaviour
{
    public TMP_Text xText;
    public Image textBackground;
    public TMP_Text textObject;
  

    // Start is called before the first frame update
    void Start()
    {

        xText.enabled = false;
     
    }

    private void Update()
    {
        if (textBackground.enabled == true && textObject.enabled == true)
        {
        
            xText.enabled = true;
        } else
        {
         
            xText.enabled = false;
        }
    }


    public void OnMouseDown()
    {
        
            Debug.Log("clicking x");
            textBackground.enabled = false;
            textObject.text = "";
            textObject.enabled = false;
        
        
    }
}
