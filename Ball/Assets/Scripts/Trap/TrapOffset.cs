using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOffset : MonoBehaviour
{   
    Vector3 StrartPosition;
    [SerializeField] Vector3 posToOffset;
    [SerializeField] float moveSpeedFoward;
    [SerializeField] float moveSpeedBack;
    [SerializeField][Range(0,1)] float moveProgress;
    bool change;

    // Start is called before the first frame update
    void Start()
    {
        StrartPosition = transform.position;
        change = false;
    }

    // Update is called once per frame
    void Update()
    {         
        moveProgress = Mathf.PingPong(Time.time * moveSpeedFoward,1);       
        
        Vector3 offset = posToOffset*moveProgress;
        transform.position = StrartPosition + offset;
    }
}
