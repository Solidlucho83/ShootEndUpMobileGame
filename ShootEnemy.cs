using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{


    public int damage;


    public GameObject particulas;

    public GameObject hitPoint;

    public float speed;

    private Transform player;
    private Vector2 target;
    public Vector2 direction;

    public GameObject particulasMuerte;


    //public float livingTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        //Destroy(this.gameObject, livingTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            Instantiate(particulasMuerte, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);

        }


    }


        private void OnTriggerEnter2D(Collider2D collision)
        {




            if (collision.gameObject.tag.Equals("Player"))
            {
                Rigidbody2D player = collision.gameObject.GetComponent<Rigidbody2D>();
                player.gameObject.GetComponent<HealtPlayer>().DamageCharacter(damage);
                Instantiate(particulas, hitPoint.transform.position, hitPoint.transform.rotation);
                Destroy(GameObject.Instantiate(particulas));
                Destroy(gameObject);
              
            }
        }

    }


   

