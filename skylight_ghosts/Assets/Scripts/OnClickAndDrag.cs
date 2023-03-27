using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OnClickAndDrag : MonoBehaviour
{
    bool mouseButtonPressed = false;

    Vector3 mouseStartPosition;
    Vector3 mousePreviousPosition;

    [SerializeField] private float dragSpeed = 0.1f;
    [SerializeField] private float minX = 4.5f;
    [SerializeField] private float maxX = 23.9f;


    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
                mouseStartPosition = Input.mousePosition;
                mousePreviousPosition = transform.position;
                
                Debug.Log("start position on mouse down");
                Debug.Log(mouseStartPosition); 
        }
         
        if(Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - mouseStartPosition;
            float deltaX = delta.x * dragSpeed;
            float newXpos = Mathf.Clamp(mousePreviousPosition.x + deltaX, minX, maxX);
            transform.position = new Vector3(newXpos, transform.position.y, transform.position.z);

        }



    }

}
   