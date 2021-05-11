using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{   
    public Transform circl;
    public float speed;    
    public enum vecToAround
    {
        right = 0,
        left =1,
        Up = 2,
        down = 3
    }
    public vecToAround around1 = vecToAround.left;
    
    void Update()
    {
        if(around1 == vecToAround.left) 
        transform.RotateAround(circl.position,Vector3.left, speed*Time.deltaTime);
        if(around1 == vecToAround.right) 
        transform.RotateAround(circl.position,Vector3.right, speed*Time.deltaTime);
        if(around1 == vecToAround.Up)
        transform.RotateAround(circl.position,Vector3.up, speed*Time.deltaTime);
        if(around1 == vecToAround.down)
        transform.RotateAround(circl.position,Vector3.down, speed*Time.deltaTime);
    }
}
