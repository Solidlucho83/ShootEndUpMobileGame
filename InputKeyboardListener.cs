using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboardListener : MonoBehaviour, Iinputeable
{
    public void GetDirection(Vector3 direction)
    {
        InputProviders.TriggerDirection(direction);
    }

 

    public void ShootPresset()
    {
        InputProviders.TriggerOnhasShoot();


    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootPresset();
        }
        GetDirection(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
       
    }
}
