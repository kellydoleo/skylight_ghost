using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickObject : MonoBehaviour
{

    public Image objectToTrigger;
    public string displayText;
    public TMP_Text textObject;
    //private Vector3 originalPosition;
    //private Vector3 originalTextPosition;
    private Transform objectClicked;
    //private Camera mainCamera;

    private bool isClicked = false;
    //private float backgroundPositionRate = 9.7f;
    //private float textPositionRate = 9f;
    

    private void Start()
    {
        //mainCamera = Camera.main;
        objectToTrigger.enabled = false;
        textObject.enabled = false;
        //originalPosition = objectToTrigger.transform.position;
        //originalTextPosition = textObject.transform.position;
        //objectClicked = GetComponent<Transform>();
        //Debug.Log("ScreenToWorldPoint x");
        //Debug.Log(mainCamera.ScreenToWorldPoint(new Vector3(0, originalPosition.y, originalPosition.z)).x);
    }



    void OnMouseDown()
    {
        if (!isClicked)
        {


            //objectToTrigger.transform.position = new Vector3((float)mainCamera.ScreenToWorldPoint(new Vector3(0, originalPosition.y, originalPosition.z)).x - backgroundPositionRate, originalPosition.y, originalPosition.z);
            //textObject.transform.position = new Vector3((float)mainCamera.ScreenToWorldPoint(new Vector3(0, originalTextPosition.y, originalTextPosition.z)).x - textPositionRate, originalTextPosition.y, originalTextPosition.z);
            //Debug.Log(objectToTrigger.transform.position.x);
            objectToTrigger.enabled = true;
            textObject.enabled = true;
            textObject.text = displayText;
            isClicked = true;
        }
        else
        {
            objectToTrigger.enabled = false;
            textObject.text = "";
            textObject.enabled = false;

            //objectToTrigger.transform.position = originalPosition;
            isClicked = false;
        } 
    }
}
