using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOn : MonoBehaviour
{   
    public Light lumen;
    bool Onf = false;
   public Transform wallIn;
   Vector3 startPosition;
   public Vector3 endPosition;
   public float step;
   public float progress;
   void Start()
   {
       startPosition = wallIn.position;
   }
   void OnTriggerEnter(Collider other)
   {      
       if(other.tag==("Player"))
       {           
           lumen.enabled = Onf;
           Onf = !Onf;
       }
   }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if(Onf == true)
        {   
            wallIn.position = Vector3.MoveTowards(wallIn.position, endPosition, step*Time.fixedDeltaTime);
            Quaternion  rotationY =Quaternion.AngleAxis(2,Vector3.up);
            wallIn.rotation *=rotationY;
            
        }
        if(Onf== false)
        {   
            wallIn.position =  Vector3.MoveTowards( wallIn.position,startPosition, step*Time.fixedDeltaTime);            
        }
    }
}
