using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowWayPoint : MonoBehaviour {

    //Arrow aiming towards finish
    [SerializeField]
    private GameObject target;
    private Vector3 targetPoint;
    private Quaternion targetRotation;

    private void Start()
    {
        target = GameObject.FindWithTag("PlayerGoal");
    } 

    void FixedUpdate()
    {
        targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z) - transform.position;

<<<<<<< HEAD
        targetRotation = Quaternion.LookRotation(targetPoint, Vector3.down);
=======
        targetRotation = Quaternion.LookRotation(targetPoint, Vector3.up);
>>>>>>> 4ca29e8ff1c181d39ce15e754dba8c5b03d65313

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0f);
    }
}