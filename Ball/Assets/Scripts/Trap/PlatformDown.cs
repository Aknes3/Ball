using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDown : MonoBehaviour
{   
    bool flag = false;
    public float fallDown;
    void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.tag == "Player"){}
    }
    
    void Update()
    {
        if(flag)
        {
             transform.Translate(Vector3.down*fallDown*Time.deltaTime);
        }
    }
}
