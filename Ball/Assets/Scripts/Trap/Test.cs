using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public bool dirRight = true;
     public float speed = 10.0f;
     public float speedBack = 2.0f;
     public float Pos;
     public float offSet;
    private AudioSource trapBoom;
     public enum Vecchoice
     {
         right1 = 0,
         left1 = 1         
     }
     public Vecchoice umn = Vecchoice.left1;
    // Start is called before the first frame update
    void Start()
    {
        trapBoom = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(umn == Vecchoice.right1)
        {
            if (dirRight)
             transform.Translate (Vector3.right * speed * Time.deltaTime);
         else
             transform.Translate (-Vector3.right * speedBack * Time.deltaTime);
         
         if(transform.position.x >= Pos) {
             trapBoom.Play();
             dirRight = false;}

         if(transform.position.x <= offSet) {
             dirRight = true;  } 
        }
        if(umn == Vecchoice.left1)
        {
            if (dirRight)
             transform.Translate (-Vector3.left * speed * Time.deltaTime);
         else
             transform.Translate (Vector3.left * speedBack * Time.deltaTime);
         
         if(transform.position.x >= Pos) {
             dirRight = false;}

         if(transform.position.x <= offSet) {
             dirRight = true;  } 
        }
        
        
    }
}
