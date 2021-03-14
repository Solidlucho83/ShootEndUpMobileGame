using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingTime : MonoBehaviour
{
  public float livingTime = 10.0f;
    void Start()
    {
        Destroy(this.gameObject, livingTime);
    }

   
}
