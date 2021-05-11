using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{   
    
    public Transform target;      
    public float horSpeed = 240f;
    public float vertSpeed = 9f;
    private float limitY = 35f;
    private float limitY1 = -35f;
    private Vector3 distance;
    private Vector3 _localPosition;
    private float _currentYRotation;
    

    
    private Vector3 _position
    {
        get{return transform.position;}
        set{transform.position = value;}
    }
    
    private float _currentYPosition;
    // Start is called before the first frame update
    void Start()
    {           
        _localPosition = target.InverseTransformPoint(_position);       
    }
   

    // Update is called once per frame
    void LateUpdate()
    {   
        _position = target.TransformPoint(_localPosition);
        RotationCamera();
        _localPosition = target.InverseTransformPoint(_position);
        
    }
    void RotationCamera()    
    {
        float deltaX = Input.GetAxis("Mouse X");
        float deltaY = Input.GetAxis("Mouse Y"); 
        if(deltaX != 0)
        {
            transform.RotateAround(target.position,Vector3.up, deltaX*horSpeed*Time.deltaTime);
        }     
        

        transform.LookAt(target);
    }

}
