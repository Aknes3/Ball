using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUP : MonoBehaviour
{   
   public Vector3 startPosition;   
   public Vector3 endPosition;
   
   public float step;
   public ParentPlatform UseIt;
    // Start is called before the first frame update
    void Start()
    {           
                      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(UseIt.GoUpflag)
        { 
           
          transform.position =  Vector3.MoveTowards(transform.position, endPosition, step*Time.fixedDeltaTime);
        }
        if(UseIt.GoUpflag==false)
        {
           transform.position =  Vector3.MoveTowards(transform.position, startPosition, step*Time.fixedDeltaTime);
        }
        
    }
}
