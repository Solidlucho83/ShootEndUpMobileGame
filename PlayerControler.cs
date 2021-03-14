using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    public float speed;


    private void Start()
    {
       
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






