using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{   
    public Transform Follow;
    private Vector3 way;
    // Start is called before the first frame update
    void Start()
    {
        way = transform.position - Follow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Follow.position + way;
    }
       
}
