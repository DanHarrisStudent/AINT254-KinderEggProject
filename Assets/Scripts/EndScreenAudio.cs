using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenAudio : MonoBehaviour {

    private float counter = 0;

    [SerializeField]
    private GameObject m_Audio_Cheer;

    void Update()
    {
        counter = counter + Time.deltaTime;


        if (counter > 1f)
        {
            m_Audio_Cheer.SetActive(true);
        }
    }
}
