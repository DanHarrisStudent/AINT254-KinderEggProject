using UnityEngine;
using System.Collections;

namespace ISS
{
    public class MoveCharacter : MonoBehaviour

    {

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

        // Use this for initialization
        void Start()
        {
            m_transform = transform;
            m_rigidbody = GetComponent<Rigidbody>();
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
            Debug.Log("Fixed Update: " + m_rotSpeed * Input.GetAxis("Horizontal"));

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                m_rigidbody.AddTorque(new Vector3(0.0f, m_rotSpeed * Input.GetAxis("Horizontal"), 0.0f));

            }
            m_rigidbody.AddForce(m_transform.forward * m_speed * Input.GetAxis("Vertical"));
        }
    }
}
