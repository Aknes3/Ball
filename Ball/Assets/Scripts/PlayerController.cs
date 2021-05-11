using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{   
    CheckPoint _poitP;
    HealthSystem _life;
    
    public Rigidbody rb;
    private GameMaster gm;
    [SerializeField] float speed = 20f;
    public float jumpForce = 2.5f;    
    public float lowJumpForce = 1.5f;
    private CharacterController _charControl;
    public Transform camera;
    Vector3 startposition;
    private Vector3 moveDirection;
    bool jump = false;
    public bool isGround;
    private AudioSource audio;

    
    
    // Start is called before the first frame update
    void Start()
    {   
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
         gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
         _poitP = GetComponent<CheckPoint>();                  
         startposition = transform.position;
         audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            jump = true;
        }

    }  
    private void OnCollisionEnter(Collision collision)
    {   
        isGround = true;       
    }
    void Jumping()
    {
        isGround = false;
        rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.VelocityChange);
        jump = false;
        //audio.Play();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(camera.forward * speed * Time.fixedDeltaTime);
        }
            
        if(Input.GetKey(KeyCode.S))
        {
             rb.AddForce(camera.forward * -speed * Time.fixedDeltaTime); 
        }
              
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(camera.right * -speed * Time.fixedDeltaTime);
        }
            
        if(Input.GetKey(KeyCode.D))
        {
             rb.AddForce(camera.right * speed * Time.fixedDeltaTime);
        }
        if(jump)
        {
            Jumping();
        }            
        
    }
}
