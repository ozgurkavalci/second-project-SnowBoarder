using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadscenetime=0.05f;
    [SerializeField] ParticleSystem crashEffect;
    
    [SerializeField] AudioClip crashSFX;
    
    bool correct=false;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Ground" && !correct)
        {

          correct=true;

          //could be done with both.

          //FindObjectOfType<JonKontroller>().DisableCOntrols();
        
          GetComponent<JonKontroller>().DisableCOntrols();

          Debug.Log("That must've hurt mate...");
          crashEffect.Play();
          
          
          GetComponent<AudioSource>().PlayOneShot(crashSFX);
          

          Invoke("ReloadScene",reloadscenetime);
        }

    }

    void ReloadScene()
    {    
        SceneManager.LoadScene(0);
    }
}
