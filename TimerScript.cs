using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class TimerScript : MonoBehaviour
{

    private float time;
    public Text timerText;

    void Start()
    {
        time = 0;
    }
    void Update()
    {
        time += Time.deltaTime;
        float minutes = Mathf.Floor(time / 60);
        float seconds = Mathf.Floor(time % 60);
        timerText.text = "TIME: " + minutes.ToString("00") + ":" + seconds.ToString("00");
        timerText.color = Color.yellow;


    }
}


