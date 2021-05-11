using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{   
    public Transform _objToFollow;
    public enum RotationAxes{
        MouseXandY = 0,
        MouseX =1,
        MouseY = 2
    }
    Transform X;
    Transform Y;
    public RotationAxes axes = RotationAxes.MouseXandY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVer = 9.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float _rotationX = 0;
    // Start is called before the first frame update
    void Start()
    {   
        Y = Camera.main.transform.parent;
        X = transform;
        Rigidbody body = GetComponent<Rigidbody>();
        if(body != null)
        {
            body.freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {   
        if(_objToFollow != null)
        {
            X.position = _objToFollow.position;
        }
        if(axes == RotationAxes.MouseX)
        {
           transform.Rotate(0,Input.GetAxis("Mouse X")*sensitivityHor,0); // поворот по горизонту
        }
        else if(axes == RotationAxes.MouseY)
        {
           _rotationX -= Input.GetAxis("Mouse Y")* sensitivityVer;
           _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
           float _rotationY = transform.localEulerAngles.y;
           transform.localEulerAngles = new Vector3(_rotationX,_rotationY,0); // rotate vertical
        }
        else
        {
            _rotationX -= Input.GetAxis("Mouse Y")* sensitivityVer*Time.deltaTime;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
           float delta = Input.GetAxis("Mouse X")* sensitivityHor*Time.deltaTime;
           float _rotationY = transform.localEulerAngles.y + delta;

           transform.localEulerAngles = new Vector3(_rotationX,_rotationY,0);// комбинированный поворот
        }
    }
}
