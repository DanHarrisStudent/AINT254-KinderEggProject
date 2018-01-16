using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAudio : MonoBehaviour {


    public AudioSource m_carEngine;

    [SerializeField]
    private float m_startingPitch = 0.6f;
    [SerializeField]
    private float m_middlePitch = 1f;

    [SerializeField]
    private Rigidbody m_playerCar;

    void Start()
    {
        m_carEngine = GetComponent<AudioSource>();
        m_carEngine.pitch = m_startingPitch;
    }

    void Update()
    {
        if(m_playerCar.velocity.magnitude > 5f)
        {
            m_carEngine.pitch = m_middlePitch;
        }       
        else
        {
            m_carEngine.pitch = m_startingPitch;
        }
    }

}
