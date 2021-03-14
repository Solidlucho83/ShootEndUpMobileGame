using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseButton : MonoBehaviour
{
    [SerializeField] public Text pause;
 

    void Start()
    {
        pause = GetComponent<Text>();
        pause.enabled = false;
    }
    // Update is called once per frame



    public void Pause()
    {
        if (Time.timeScale == 1f)
        {
          

            Time.timeScale = 0f;
            pause.enabled = true;
           

        }
        else
        {
           
            Time.timeScale = 1f;
            pause.enabled = false;

        }
    }
}
