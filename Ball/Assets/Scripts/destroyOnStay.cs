using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnStay : MonoBehaviour
{
   void OnCollisionExit(Collision othe)
   {
       if(othe.gameObject.tag == "Player")
       {
           Destroy(gameObject,1);
       }
   }
    
}
