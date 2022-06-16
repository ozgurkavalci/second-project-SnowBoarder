using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] ParticleSystem finishingEffect;
    [SerializeField] float reloadscenetime=1f;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Player")
        {
        Debug.Log("You finished!!!");
        finishingEffect.Play();
        GetComponent<AudioSource>().Play();
        Invoke("ReloadScene",reloadscenetime);
        
        }
    }
    void ReloadScene()
    {    
        SceneManager.LoadScene(0);
    }


}
