using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOn : MonoBehaviour
{   
    private AudioSource takeBall1;
    public GameObject magicfire;
    public Transform platform;
    MeshRenderer mesh1;
    private BoxCollider box1;
    [SerializeField] float _speed;
    public Vector3 endPos;
    bool flagg = false;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            if(takeBall1 != null)
            {
                takeBall1.Play();
            }            
            mesh1.enabled = false;
            magicfire.SetActive(true);
            flagg = true;
           box1.enabled = false;
        }
    }
    void Update()
    {   
        if(flagg)
        platform.position = Vector3.MoveTowards(platform.position, endPos,_speed*Time.deltaTime);
    }
    void Start()
    {   
        takeBall1 = GetComponent<AudioSource>();
        mesh1 = GetComponent<MeshRenderer>();
        box1 = GetComponent<BoxCollider>();
    }
    
}
