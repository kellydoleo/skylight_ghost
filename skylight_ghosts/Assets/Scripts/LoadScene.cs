using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LoadScene : MonoBehaviour
{
    public KeyCode sceneLoadButton;
    public string sceneToLoad;
    bool hasTriggered; 
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(sceneLoadButton) && hasTriggered == false)
        {
            SceneManager.LoadScene(sceneToLoad);
            hasTriggered = true;
        }
    }
}
