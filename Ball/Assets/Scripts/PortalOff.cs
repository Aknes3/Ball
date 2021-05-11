using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOff : MonoBehaviour
{
    public BoxCollider portala;
    public GameObject light1;
    public MeshRenderer lux;
    public Light sun;
    private AudioSource takeIt;
    bool flag = false;

    
    // Start is called before the first frame update
    void Start()
    {
        takeIt = GetComponent<AudioSource>();
    }
    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            flag = true;
            portala.gameObject.SetActive(false);
            lux.enabled = false;
            light1.SetActive(true);
            takeIt.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(flag)
        {
            sun.intensity -= 0.08f*Time.deltaTime;
            if(sun.intensity == 0){Destroy(gameObject);}
        }
    }
}
