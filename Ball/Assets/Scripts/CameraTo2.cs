using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTo2 : MonoBehaviour
{   
   
    [SerializeField] float sensitivityHor = 9.9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Mouse X")*sensitivityHor*Time.deltaTime;
        //float rotationY = transform.localEulerAngles.y + deltaX;
        transform.Rotate(0,deltaX,0);
        //transform.localEulerAngles = new Vector3(0,rotationY,0);

        
    }
}
