using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public  static int scoreValue = 0;
  
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        
        score = GetComponent<Text>();
      //  DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "SCORE: " + scoreValue;
        score.color = Color.blue;
        if(scoreValue > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scoreValue);
        }
    }
    
}
