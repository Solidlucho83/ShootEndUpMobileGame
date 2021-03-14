using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, 0 * speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.y, 0, 0), 50, 0);

    }
    }
