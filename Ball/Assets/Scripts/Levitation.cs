using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitation : MonoBehaviour
{   
    public float speedForce = 10f;
    // Start is called before the first frame update
   private void OnTriggerStay(Collider other)
   {
       Rigidbody rbPlay;
       rbPlay = other.GetComponent<Rigidbody>();
       rbPlay.AddForce(Vector3.up*Time.deltaTime*speedForce);
   }
   //void FixedUpdate()
   
       
   
}
