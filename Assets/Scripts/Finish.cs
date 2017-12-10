using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {


    //When player hits trigger, send player to Finish Scene.
    private void OnTriggerEnter(Collider other)
    {
        //Activate next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
