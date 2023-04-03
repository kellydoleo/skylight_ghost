using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAudioOnClick : MonoBehaviour
{

    public AudioSource audioSource;
    private bool isAudioPlaying = true;
    private Button button; 
    


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.interactable = true;

    }

    private void OnMouseDown()
    {
        // If the audio is playing, stop it and set the flag to false
        if (isAudioPlaying)
        {
            Debug.Log("Stop audio");
            audioSource.Stop();
            isAudioPlaying = false;
            button.interactable = false; 
            
        }
        // If the audio is not playing, play it and set the flag to true
        else
        {
            Debug.Log("Start audio");
            audioSource.Play();
            isAudioPlaying = true;
            button.interactable = true;
           
        }
    }
}
