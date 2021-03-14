using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtPlayer : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public static Play play;
    public static IntertistialAdmob intertistialAdmob;

    public GameObject particulasMuerte;
    public GameObject ParticulasHealt;
    public GameObject prefab;

    private SpriteRenderer characterRenderer;

    //llamamos al agitador de camara
    public CameraShake cameraShake;


    //menu Ondisanble

    public RectTransform GameOverMenu;




    //llamamos al SoundManager
    private SfxSoundManager SfxSoundManager;



    void Start()
    {
        currentHealth = maxHealth;

        characterRenderer = GetComponent<SpriteRenderer>();
        SfxSoundManager = FindObjectOfType<SfxSoundManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            //llamamos al agitador de camara
            StartCoroutine(cameraShake.Shake(.15f, .4f));
            //

            DoInstantiator();
           







        }
    }

    public void DoInstantiator()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        
        gameObject.SetActive(false);

    }
    public void DamageCharacter(int damage)
    {
        currentHealth -= damage;
        SfxSoundManager.Hurt.Play();
        StartCoroutine(cameraShake.Shake(.10f, .4f));
        StartCoroutine(Visual());


    }

    public void UpdateMaxHealt(int newMaxHealt)
    {
        maxHealth = newMaxHealt;
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {




        if (collision.gameObject.tag.Equals("Enemigo"))
        {
            currentHealth -= 10;
            SfxSoundManager.Hurt.Play();
            StartCoroutine(cameraShake.Shake(.10f, .4f));
           // Destroy(collision.gameObject);
            StartCoroutine(Visual());
            
        }
        if (collision.gameObject.tag.Equals("Toro"))
        {
            currentHealth -= 10;
            SfxSoundManager.Hurt.Play();
            StartCoroutine(cameraShake.Shake(.10f, .4f));
         
            StartCoroutine(Visual());

        }


        if (collision.gameObject.tag.Equals("Healt"))
        {
            currentHealth = 30;
            Instantiate(ParticulasHealt, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(collision.gameObject);
            SfxSoundManager.Items.Play();
        }




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

    private void OnDisable()
    {



        
        GameOverMenu.gameObject.SetActive(true);
        if (Time.timeScale == 1f)
        {

            Time.timeScale = 0f;

        }
      

    

    }

    private void OnEnable()
    {
        if (Time.timeScale == 0f)
        {

            Time.timeScale = 1f;

        }

    }
      


}