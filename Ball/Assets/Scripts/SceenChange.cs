using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceenChange : MonoBehaviour
{
    private AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
   void OnTriggerEnter(Collider other)
   {
       if(other.CompareTag("Player"))
       {
           NextLevel();
           if(audio != null)
           {
               audio.Play();
           }
           
       }
   }
   void NextLevel()
   {
       int currentLevel = SceneManager.GetActiveScene().buildIndex;
       int _NextLevel = currentLevel+1;
       if(currentLevel == SceneManager.sceneCountInBuildSettings)
       {
           currentLevel = 0 ;
       }
       SceneManager.LoadScene(_NextLevel);
   }
}
