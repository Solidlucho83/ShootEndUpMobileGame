using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDamage : MonoBehaviour
{
    public int damage;


    public GameObject particulas;

    public GameObject hitPoint;
   

 


    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag.Equals("Enemigo"))
        {
            Rigidbody2D enemy = collision.gameObject.GetComponent<Rigidbody2D>();
            enemy.gameObject.GetComponent<HealtEnemy>().DamageCharacter(damage);
            Instantiate(particulas, hitPoint.transform.position, hitPoint.transform.rotation);
            Destroy(GameObject.Instantiate(particulas));
            Destroy(gameObject);
            Debug.Log("Toco al Enemigo!");
        }
        if (collision.gameObject.tag.Equals("Boss"))
        {
            Rigidbody2D enemy = collision.gameObject.GetComponent<Rigidbody2D>();
            enemy.gameObject.GetComponent<HealtBoss>().DamageCharacter(damage);
            Instantiate(particulas, hitPoint.transform.position, hitPoint.transform.rotation);
            Destroy(GameObject.Instantiate(particulas));
            Destroy(gameObject);
            Debug.Log("Toco al Boss!");
        }

    }



   
 

}
