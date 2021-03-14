using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    
  public void RestarLevel()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;

        }
     
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreRestar();
    }

    public void ScoreRestar()
    {
        ScoreScript.scoreValue = 0;
        KillCounter.killed = 0;
    }
}
