using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst : MonoBehaviour
{   
    public GameObject balls;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 spawnvalue = new Vector3(Random.Range(-transform.localScale.x/2,transform.localScale.x/2),transform.localScale.y/2,Random.Range(-transform.localScale.z/2,transform.localScale.z/2));
        Instantiate(balls,spawnvalue+transform.position,transform.rotation);
    }
}
