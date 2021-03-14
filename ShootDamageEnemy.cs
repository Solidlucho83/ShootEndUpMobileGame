using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDamageEnemy : MonoBehaviour
{


 public int damage;


public GameObject particulas;

public GameObject hitPoint;





private void OnTriggerEnter2D(Collider2D collision)
{


    
    
    if (collision.gameObject.tag.Equals("Player"))
    {
        Rigidbody2D player = collision.gameObject.GetComponent<Rigidbody2D>();
        player.gameObject.GetComponent<HealtPlayer>().DamageCharacter(damage);
        Instantiate(particulas, hitPoint.transform.position, hitPoint.transform.rotation);
        Destroy(GameObject.Instantiate(particulas));
        Destroy(gameObject);
        Debug.Log("TocoPlayer!");
    }
}



   
 

}
