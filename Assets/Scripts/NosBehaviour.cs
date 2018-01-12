using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NosBehaviour : MonoBehaviour
{

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player_1")
        Destroy(gameObject, 0.2f);
    }
}
