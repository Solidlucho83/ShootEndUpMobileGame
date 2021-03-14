using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtBoss : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;



    public GameObject particulasMuerte;

    public GameObject prefab;

    private SpriteRenderer characterRenderer;

  


    public int enemyValue;
    private int enemykilled = 1;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        characterRenderer = GetComponent<SpriteRenderer>();




    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            ScoreScript.scoreValue += enemyValue;
            KillCounter.killed += enemykilled;


            Debug.Log(enemyValue);
           
            DoInstantiator();
        






        }
    }



    public void DoInstantiator()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        Destroy(gameObject); 
     


    }
    public void DamageCharacter(int damage)
    {
        currentHealth -= damage;
        StartCoroutine(Visual());


    }

    public void UpdateMaxHealt(int newMaxHealt)
    {
        maxHealth = newMaxHealt;
        currentHealth = maxHealth;
    }




    private IEnumerator Visual()
    {
        characterRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);

        characterRenderer.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        characterRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);

        characterRenderer.color = Color.white;
        yield return new WaitForSeconds(0.1f);
    }
}
