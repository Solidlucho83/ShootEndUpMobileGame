using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossIA2 : MonoBehaviour
{
    [Header("Shooter Config")]
    public bool isShotter;
    public float shootCadence;
    public float shootInitialTime;
    private Shotter[] shotters;

    [Header("Follow IA")]
    public Transform target;

    public float stopRadius;
    public float attackRadius;

    [Header("Mover")]
    public Vector3 direction;
    public float speed;




    private void Start()
    {

        //folowIA

        target = GameObject.FindGameObjectWithTag("Player").transform;
        //


        shotters = GetComponentsInChildren<Shotter>();
        if (shotters != null && shotters.Length > 0)
        {
            StartCoroutine(ShootForever());
        }



    }



    private IEnumerator ShootForever()
    {
        yield return new WaitForSeconds(shootInitialTime);
        while (true)
        {
            foreach (var shooter in shotters)
            {
                shooter.DoShoot();
            }
            yield return new WaitForSeconds(shootCadence);
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
       StartCoroutine(CheckDistance());
    }

    private IEnumerator CheckDistance()
    {



        if (Vector3.Distance(target.position, transform.position) <= stopRadius)

        {

            transform.Translate(direction * (-speed - 4) * Time.deltaTime);


            if (Vector3.Distance(target.position, transform.position) <= attackRadius)

            {


                transform.position = Vector3.MoveTowards(transform.position,
                  target.position, (speed ) * Time.deltaTime);
                shootCadence = 5f;



                yield return null;
                yield return new WaitForSeconds(0f);

                
            }
        }
    
    }



    
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, stopRadius);
        Gizmos.DrawWireSphere(transform.position, attackRadius);

    }
}





