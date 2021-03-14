using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 direction;
    public float speed;


    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

    }
}
