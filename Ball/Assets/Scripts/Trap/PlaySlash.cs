using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySlash : MonoBehaviour
{
    private AudioSource playSound;
    // Start is called before the first frame update
    void Start()
    {   

        playSound = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider collider)
    {
        if(playSound != null)
        {
            if(collider.CompareTag("Player"))
            {
                playSound.Play();
            }
        }
    }
    
   
}
