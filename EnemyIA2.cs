using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA2 : MonoBehaviour
{
  

    [Header("Follow IA")]
    public Transform target;

 
    public float attackRadius;

    [Header("Mover")]
    public Vector3 direction;
    public float speed;




    private void Start()
    {
        //folowIA
      
        target = GameObject.FindGameObjectWithTag("Player").transform;
    
        //


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
       StartCoroutine(CheckDistance());
    }

    private IEnumerator CheckDistance()
    {



            if (Vector3.Distance(target.position, transform.position) <= attackRadius)

            {

              
                transform.position = Vector3.MoveTowards(transform.position,
                  target.position, (speed +1f) * Time.deltaTime);
            


        yield return null;
        yield return new WaitForSeconds(3f);

            transform.Translate(direction * speed * Time.deltaTime);


        }
   

    }
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.yellow;
    
        Gizmos.DrawWireSphere(transform.position, attackRadius);

    }
}
