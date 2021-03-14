using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{

    public float livingTime = 3.0f;

    private SpriteRenderer characterRenderer;



    private void Awake()
    {
        characterRenderer = GetComponent<SpriteRenderer>();
        

    }
    void Start()
    {
        StartCoroutine(Visual());
       // Destroy(this.gameObject, livingTime);
    }
    private IEnumerator Visual()
    {
        characterRenderer.color = Color.clear;
        yield return new WaitForSeconds(0.1f);

        characterRenderer.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        characterRenderer.color = Color.clear;
        yield return new WaitForSeconds(0.1f);

        characterRenderer.color = Color.white;
        yield return new WaitForSeconds(0.1f);

        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("Level1");
        
       // Time.timeScale = 0;
        






    }

   
}
