using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{   
    public float speed = 6f;
    private CharacterController _charControl;
    // Start is called before the first frame update
    void Start()
    {
        _charControl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal")*speed;
        float deltaZ = Input.GetAxis("Vertical")*speed;
        Vector3 Movement = new Vector3(deltaX,0,deltaZ);
        Movement = Vector3.ClampMagnitude(Movement,speed);
        Movement *=Time.deltaTime;
        Movement = transform.TransformDirection(Movement);
        _charControl.Move(Movement);
    }
}
