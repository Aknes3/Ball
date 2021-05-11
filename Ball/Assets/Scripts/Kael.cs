using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kael : MonoBehaviour
{   
    private AudioSource KaelMoving;
    public float orbitDistance;
     public float orbitDegreesPerSec = 180.0f;
     public Vector3 relativeDistance;
    public float speedRot;
    public Transform sphere;
    bool tuch = false;
    
     void Start()
     {
         KaelMoving = GetComponent<AudioSource>();
     }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {   
            tuch = true;             
            relativeDistance = (transform.position - sphere.position)*2.4f;
            KaelMoving.Play();             
        }
    }   
     
    void FixedUpdate()
    {   
                  
        if(tuch == true){ 
             
        transform.position = sphere.position + relativeDistance;
        transform.RotateAround(sphere.position, Vector3.up, orbitDegreesPerSec * Time.fixedDeltaTime);
        relativeDistance = transform.position - sphere.position;
        
        if(Input.GetKey(KeyCode.F))
        {  
            
           KaelMoving.pitch = 1.5f;
           orbitDegreesPerSec = 900; 
        }
        else
        {   
            
            orbitDegreesPerSec = 180.0f;
        } 
        }
        
    }
}
