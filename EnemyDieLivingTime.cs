using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDieLivingTime : MonoBehaviour
{
    

  
 

    public float livingTime = 4.0f;

    private SpriteRenderer characterRenderer;
  

    private void Awake()
    {
        characterRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        StartCoroutine(Visual());
        Destroy(this.gameObject, livingTime);
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
    }



}


