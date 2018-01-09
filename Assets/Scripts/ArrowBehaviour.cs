using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform m_carTransform;

    [SerializeField]
    private Transform m_goal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 temPos = m_carTransform.position;
        temPos.y += 2.0f;
        transform.position = temPos;

        transform.LookAt(m_goal);
    }
}
