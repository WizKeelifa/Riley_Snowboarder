using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetecter : MonoBehaviour
{
    [SerializeField] float loadDelay = .5f;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Invoke("ReloadScene", loadDelay);
        }
    }
    void ReloadScene()
    {
        {
        SceneManager.LoadScene(0);            
        }        
    }
}