using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
 
    public GameObject particulas;

    public GameObject hitPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {




        if (collision.gameObject.tag.Equals("Player"))
        {

            Rigidbody2D player = collision.gameObject.GetComponent<Rigidbody2D>();

            /* if (player.transform.parent.GetChild(2) ==false && player.transform.parent.GetChild(4) == false)
             {
                 player.transform.parent.GetChild(2).gameObject.SetActive(true);
             }

             if (player.transform.parent.GetChild(2) == true && player.transform.parent.GetChild(4) == false)
                 player.transform.parent.GetChild(4).gameObject.SetActive(true);
             }
         else
         {
             Debug.Log("Ya estas a Tope");
         }*/
            player.transform.parent.GetChild(1).gameObject.SetActive(true);
            Instantiate(particulas, hitPoint.transform.position, hitPoint.transform.rotation);
            Destroy(GameObject.Instantiate(particulas));
            Destroy(gameObject);
            Debug.Log("POWEUP X 2!");
        }
    }
}
    

