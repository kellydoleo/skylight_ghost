using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public float totalPoints;
    public GameObject itemToTrigger; 

    // Start is called before the first frame update
    void Start()
    {
        itemToTrigger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(totalPoints == 9)
        {
            itemToTrigger.SetActive(true);
        }
        
    }
}
