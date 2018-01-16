using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudio : MonoBehaviour
{

    private float counter = 0;

    [SerializeField]
    private GameObject m_Audio_Radio;

    [SerializeField]
    private GameObject m_Audio_Slap;

    [SerializeField]
    private GameObject m_Audio_Yawn;

    [SerializeField]
    private GameObject m_Audio_Ahh;

    [SerializeField]
    private GameObject m_Audio_DoorSlam;

    [SerializeField]
    private GameObject m_Audio_EngineStart;

    [SerializeField]
    private GameObject m_Player;

    [SerializeField]
    private GameObject m_MiniMap;

    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        counter = counter + Time.deltaTime;

        if(counter > 5f)
        {
            m_Audio_Slap.SetActive(true);
        }
        if (counter > 6f)
        {
            m_Audio_Yawn.SetActive(true);
        }

        if (counter > 10f)
        {
            m_Audio_Ahh.SetActive(true);
        }

        if (counter > 15f)
        {
            m_Audio_DoorSlam.SetActive(true);
        }

        if (counter > 16f)
        {
            m_Player.SetActive(true);
        }

        if (counter > 18f)
        {
            m_Audio_EngineStart.SetActive(true);
            m_MiniMap.SetActive(true);
        }

        if (counter > 20.5f)
        {
            m_Audio_Radio.SetActive(true);
        }
    }


}
