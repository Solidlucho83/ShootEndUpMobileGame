using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class Controler : MonoBehaviour
{
    //public Mover moverComponet;
    public float speed;
    public Boundary boundary;

    [Header("Shooter Config")]
    public bool isShotter;
    public float shootCadence;
    public float shootInitialTime;
    private Shotter[] shotters;


    [Header("Config PowerUp")]
    public int canons = 1;
    public GameObject ParticulasItems;
    private SfxSoundManager SfxSoundManager;



    /*[SerializeField] private List<Shotter> shotters; */
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;


    private void Start()
    {
        SfxSoundManager = FindObjectOfType<SfxSoundManager>();
        rb = GetComponent<Rigidbody2D>();

        //moverComponet.speed = speed;

       /* InputProviders.OnhasShoot += OnhasShoot;*/
       /* InputProviders.OnDirection += OnDirection;*/

        //shoter
        shotters = GetComponentsInChildren<Shotter>();
        if (shotters != null && shotters.Length > 0)
        {

            StartCoroutine(ShootForever());
        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals("PowerUp"))
        {


            if (canons < 3)
            {
                canons += 1;
                ScoreScript.scoreValue += 500;
            }
            else
            {
                ScoreScript.scoreValue += 500;
            }
            Instantiate(ParticulasItems, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(collision.gameObject);
            SfxSoundManager.Items.Play();
        }
        if (collision.gameObject.tag.Equals("SpeedUp"))
        {


            if (shootCadence > 0.8f)
            {
                shootCadence -= .1f;

            }
             if (speed < 6)
            {
                speed += 0.5f;
            }
            else
            {
                ScoreScript.scoreValue += 500;
            }
            Instantiate(ParticulasItems, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(collision.gameObject);
            SfxSoundManager.Items.Play();

        }
        

            if (collision.gameObject.tag.Equals("Enemigo"))
            {
                Rigidbody2D enemy = collision.gameObject.GetComponent<Rigidbody2D>();
                enemy.gameObject.GetComponent<HealtEnemy>().DamageCharacter(30);
                
                Debug.Log("Toco al Enemigo!");
            }







        }


    private IEnumerator ShootForever()
    {
        yield return new WaitForSeconds(shootInitialTime);
        while (true)
        {
            for (int i = 0; i < canons; i++)
            //foreach (var shooter in shotters)
            {
                var shooter = shotters[i];
                shooter.DoShoot();
            }
            yield return new WaitForSeconds(shootCadence);
        }
    }
  

   /* private void OnDirection(Vector3 direction)
    {
        moverComponet.direction = direction;
    }*/

    private void OnhasShoot()
    {
        //Instantiate(shootPrefabs, shootOrigins, false); #esta config se puede usar con laser, el disparo es hijo del origins
        foreach (var shotter in shotters)
        {
            shotter.DoShoot();
        }
    }


    void Update()
    {

      

        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);
        transform.Translate(direction * speed * Time.deltaTime);
        //moverComponet.direction = direction;
        float x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
        float y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
        transform.position = new Vector3(x, y);
        

 

    }
    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * speed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
        }
    }






}
