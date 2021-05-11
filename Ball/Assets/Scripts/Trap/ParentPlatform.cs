using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentPlatform : MonoBehaviour
{   
    private AudioSource platformMove;
    public bool GoUpflag = false;
    void Start()
    {
        platformMove = GetComponent<AudioSource>();
    }
    void OnCollisionStay(Collision other)
   {
       if(other.gameObject.tag == ("Player"))
        {   
           
            GoUpflag = true;      
            other.transform.parent = this.transform.parent;
        }
   }
   void OnCollisionExit(Collision other)
   {
        if(other.gameObject.tag == ("Player"))
        {            
            other.transform.parent = null;
            GoUpflag = false;
            if(platformMove !=null)
            platformMove.Stop();
        }
   }
   void OnCollisionEnter(Collision collision)
   {    
       if(platformMove != null)
       platformMove.Play();
   }
   
}
