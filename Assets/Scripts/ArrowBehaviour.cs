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
<<<<<<< HEAD
        temPos.y += 1.0f;
      
=======
        temPos.y += 2.0f;
>>>>>>> ff0734d1b3aa84f837421d7d8550edcc720defc6
        transform.position = temPos;

        transform.LookAt(m_goal);
    }
}
