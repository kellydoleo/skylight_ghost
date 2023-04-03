using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickObject : MonoBehaviour
{

    public PlayerPoints points; 
    public Image objectToTrigger;
    public string displayText;
    public TMP_Text textObject;
    private List<string> items = new List<string>();

    private bool isClicked = false;

    private void Start()
    {
        objectToTrigger.enabled = false;
        textObject.enabled = false;
    }


    void OnMouseDown()
    {
        if (!isClicked)
        {
            Debug.Log("this.gameObject");
            Debug.Log(this.gameObject.tag);
            objectToTrigger.enabled = true;
            textObject.enabled = true;
            textObject.text = displayText;
            isClicked = true;
            if(!items.Contains(this.gameObject.tag))
            {
                points.totalPoints += 1;
            }
            items.Add(this.gameObject.tag);
            Debug.Log(points.totalPoints);
           
           

        }
        else
        {
            objectToTrigger.enabled = false;
            textObject.text = "";
            textObject.enabled = false;
            isClicked = false;
        } 
    }
}
