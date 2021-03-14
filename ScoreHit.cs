using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHit : MonoBehaviour
{
    public static int scoreValue = 0;

    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.scoreValue > ScoreHit.scoreValue)
        {
            score.text = "HIT:   " + ScoreScript.scoreValue;
        }
        else
        {
            score.text = "HIT:   " + scoreValue;
        }
        

    }
}
