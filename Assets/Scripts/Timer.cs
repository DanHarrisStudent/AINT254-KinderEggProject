using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    //Reference to text object
    public Text counterText;

    //Create veriables for time
    public float seconds, minutes;

    void Start()
    {
        counterText = GetComponent<Text>() as Text;
    }
    
    void Update()
    {
        minutes = (int)(Time.timeSinceLevelLoad / 60f);
        seconds = (int)(Time.timeSinceLevelLoad % 60f);
        counterText.text = "09:" + minutes.ToString("00") +":"+ seconds.ToString("00")+ " AM";
    }

}
