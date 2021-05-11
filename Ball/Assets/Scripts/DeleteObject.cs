using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{   
    
    private AudioSource minusLife;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {  
            if(minusLife != null) 
            minusLife.Play();
            Destroy(gameObject);
        }       
        
    }
    void Start()
    {
        minusLife = GetComponent<AudioSource>();
    }
}
