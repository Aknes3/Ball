using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{   
    private AudioSource rockBoom;
    bool flag = false;
    public float force1;
     Rigidbody rb;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Kael")
        {
            flag = true;
            rockBoom.Play();
             Destroy(gameObject,1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
       rockBoom = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(flag)
        {
           // rb.AddForce(transform.forward*force1*Time.fixedDeltaTime,ForceMode.Impulse);
           
        }
    }
}
