using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{   
    public int health;
    public int numberOfHEalth;
    private GameMaster gm;
    CheckPoint _poitP;
    public Image [] lives;
    public Sprite fullLife;
    public Sprite emptyLife;
    int life = 3;
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Enemy":            
                life--;
                health--;
                Debug.Log(life);
                transform.position = gm.LastCheckPointPos;                           
            break;      
                        
        }
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            life--;
            health--;
             transform.position = gm.LastCheckPointPos;
        }
        if(other.CompareTag("bonus"))
        {
            life--;
            health--;            
        }
        
        if(other.CompareTag("Enemy")&other.CompareTag("WallKill"))
        {
            life--;
            health--;
             transform.position = gm.LastCheckPointPos;
        }
    }
    //смерть и перезагрузка сцены
    void Death()
    {
        if(life<1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);                     
        }

    }
    
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        _poitP = GetComponent<CheckPoint>();
    }

    // Update is called once per frame
    void Update()
    {   
        Death(); 

        for( int i =0; i<lives.Length; i++)
        {   
            if(i<health)
            {
                lives[i].sprite = fullLife;
            }
            else
            {
                lives[i].sprite = emptyLife;
            }
            if(i<numberOfHEalth)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }
}
