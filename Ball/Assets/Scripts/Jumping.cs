using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{   
    private AudioSource jumpUp;
    [SerializeField] float _force;
    Rigidbody rb;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            rb = other.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up*_force);
            jumpUp.Play();
        }
    }    
    void Start()
    {
        jumpUp = GetComponent<AudioSource>();
    }
}
