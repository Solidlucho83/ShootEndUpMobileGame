using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    private float TiempoNivel = 20.0f;



    void Start()
    {
        StartCoroutine(FinishLevel());

    }
    private IEnumerator FinishLevel()
    {


        yield return new WaitForSeconds(TiempoNivel);
        SceneManager.LoadScene("Title");





    }
   

}
