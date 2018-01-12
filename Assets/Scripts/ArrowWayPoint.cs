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

        targetRotation = Quaternion.LookRotation(targetPoint, Vector3.down);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0f);
    }
}