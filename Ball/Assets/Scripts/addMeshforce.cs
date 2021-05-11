using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addMeshforce : MonoBehaviour
{   
    private AudioSource portal2;
    public float force = 10f;
    public Transform teleport;
    private void OnTriggerEnter(Collider other)
    {
        //Rigidbody rbPlayer;
        Transform position;
        position = other.GetComponent<Transform>();
        position.position = teleport.position;
       // rbPlayer = other.GetComponent<Rigidbody>();
       // rbPlayer.AddForce(transform.up * force);
        Debug.Log("InComing");
        if(portal2 != null)
        {
            portal2.Play();
        }
    }
    void Start()
    {
        portal2 = GetComponent<AudioSource>();
    }
}
