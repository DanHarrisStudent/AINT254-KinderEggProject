using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPlayer : MonoBehaviour
{

    ////Checks if the player is touching the ground and resets the rotation if not

    //public LayerMask groundLayer;

    //[SerializeField]
    //private GameObject m_player;

    //[SerializeField]
    //private float m_rayDistance = 2.0f;

    //[SerializeField]
    //private float m_flipTime;

    //private void Update()
    //{
    //    RaycastHit hit;
    //    Ray groundRay = new Ray(transform.position, Vector3.down);

    //    if(Physics.Raycast(groundRay, out hit, m_rayDistance))
    //    {
    //        if(hit.collider.tag != "Ground")
    //        {
    //           // m_player.transform.rotation = Quaternion.Euler(new Vector3(m_,0,0));
    //        }
    //    }
    //}
    //private void OnDrawGizmos()
    //{
    //    Debug.DrawRay(m_player.transform.position, Vector3.down, Color.green);

    //}

}
