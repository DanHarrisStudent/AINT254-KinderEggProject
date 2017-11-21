using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {

    //Checkpoint system, User must enter collider to activate next checkpoint, 
    //next partical system acitavtes after user hits collider.
    
    public GameObject Flare;
    
    private void OnTriggerEnter(Collider other)
    {
        Flare.SetActive(false);


        SceneManager.LoadScene(0);

    }   
    
}
