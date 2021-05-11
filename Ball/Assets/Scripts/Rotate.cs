using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{   
    
    Vector3 _pull;    
    
    // Start is called before the first frame update
   public enum RotateFor
    {
        Quat =0,
        WithTransf = 1
    }
    public RotateFor MixRotate;
    void Start()
    {        
        _pull = new Vector3(0,0,50);         
    }

    // Update is called once per frame
    void Update()
    {   
        if(MixRotate ==  RotateFor.Quat)
        {
            Quaternion opiu = Quaternion.AngleAxis(1,Vector3.forward);
            transform.rotation *= opiu; 
        }
        if(MixRotate ==  RotateFor.WithTransf)
        {            
            transform.Rotate (0,0,Time.deltaTime*60,Space.World); 
        }
               
    }
}
