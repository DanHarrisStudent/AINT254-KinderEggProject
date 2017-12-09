using UnityEngine;
using System.Collections;

namespace ISS
{
    public class MoveCharacter : MonoBehaviour

    {
        public Vector3 com = Vector3.zero;
        public LayerMask groundLayer;
        public Camera camera;

        [SerializeField]
        private float m_speed = 5.0f;

        [SerializeField]
        private float m_rotSpeed = 50.0f;

        [SerializeField]
        private float cameraDistance = 5.0f;

        [SerializeField]
        private float camerHight = 2.0f;

        [SerializeField]
        private float angleX = 30.0f;


        private Transform m_transform;
        private Rigidbody m_rigidbody;

        [SerializeField]
        private float m_rayDistance = 2.0f;

        // Use this for initialization
        void Start()
        {
            m_transform = transform;
            m_rigidbody = GetComponent<Rigidbody>();

            m_rigidbody.centerOfMass = com;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            Vector3 currenCamPos = camera.transform.position;

            Quaternion currenCamRot = camera.transform.rotation;            

            float angle = gameObject.transform.rotation.eulerAngles.y;

            camera.transform.rotation = Quaternion.Lerp(currenCamRot, Quaternion.Euler(new Vector3(angleX, angle, 0.0f)), 0.1f);

            Vector3 newCamPos = transform.position + new Vector3(- cameraDistance * Mathf.Sin(angle*Mathf.Deg2Rad), camerHight, - cameraDistance * Mathf.Cos(angle*Mathf.Deg2Rad));

            camera.transform.position = Vector3.Lerp(currenCamPos, newCamPos, 0.1f);
            

        }

        void FixedUpdate()
        {
            //Debug.Log("Fixed Update Horizontal: " + m_rotSpeed * Input.GetAxis("Horizontal"));
            //Debug.Log("Fixed Update Vertical: " + m_speed * Input.GetAxis("Vertical"));

            RaycastHit hit;
            Ray groundRay = new Ray(m_transform.position, Vector3.down);

            if (Physics.Raycast(groundRay, out hit, m_rayDistance))
            {
                //Debug.Log("Any collision");
                //if (hit.collider.tag == "Ground")
                //{
                    //Debug.Log("Hit ground");
                    // m_player.transform.rotation = Quaternion.Euler(new Vector3(m_,0,0));
                    if (m_rigidbody.velocity.magnitude > 0.7)
                    {
                        Debug.Log("Working here");
                        m_rigidbody.AddTorque(new Vector3(0.0f, m_rotSpeed * Input.GetAxis("Horizontal"), 0.0f));

                    }
                    m_rigidbody.AddForce(m_transform.forward * m_speed * Input.GetAxis("Vertical"));
                //}
            }

           
        }
    }
}
