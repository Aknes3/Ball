using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCilindr : MonoBehaviour
{   
    private AudioSource flyOut;
    public float speed;
    public float speed2;
    bool flag = false;
    public float posY;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == ("Player"))
        {   
            flyOut.Play();
            flag = true;
        }
    }   

    void Start()
    {
        flyOut = GetComponent<AudioSource>();
    }
    void Update()
    {   
        BallUp();      
         
    }
    void BallUp()
    {
        if(flag)
        {
            transform.Translate(Vector3.up*speed*Time.deltaTime);
        }
        if(transform.position.y >= posY) 
        {
            speed = speed2 ;
            Destroy(gameObject,8);
        }
          
    }
}
