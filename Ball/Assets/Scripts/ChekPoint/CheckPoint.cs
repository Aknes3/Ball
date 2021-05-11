using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{   
    private GameMaster gm;
    private AudioSource audio1;
 
    // Start is called before the first frame update
    void Start()
    {   
        //self = false;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        audio1 = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gm.LastCheckPointPos = transform.position;
            audio1.Play();
                                 
        }
    }

    
}
